package test

import (
	"os"
	// "os"
	// "io"
	"encoding/json"
	"fmt"
	"net/http"
	"net/url"
	"strings"
	"text/template"
	"time"
)

const IssuesURL = "https://api.github.com/search/issues"

//`https://developer.github.com/v3/`

type IssuesSearchResult struct {
	TotalCount int `json:"total_count"`
	Items      []*Issues
}

type Issues struct {
	Number   int
	HTMLURL  string `json:"html_url"`
	Title    string
	State    string
	User     *User
	CreateAt time.Time `json:"created_at"`
	Body     string
}

type User struct {
	Login   string
	HTMLURL string `json:"html_url"`
}

func getTempl() *template.Template {
	const strTempl = `{{.TotalCount}} issues:
{{range .Items}}--------------------------------------
Numner: {{.Number}}
User: {{.User.Login}}
Title: {{.Title | printf "%.64s"}}
Age: {{.CreateAt | daysAgo}} days
{{end}}`

	repo, err := template.New("issuesList").
		Funcs(template.FuncMap{"daysAgo": daysAgo}).
		Parse(strTempl)
	if err != nil {
		fmt.Printf("create template fail : %s\n", err)
		return nil
	}
	return repo
}

func daysAgo(t time.Time) int {
	return int(time.Since(t).Hours() / 24)
}

func PrintSearchIssues(terms []string) {
	result, err := SearchIssues(terms)
	if err != nil {
		fmt.Println(err)
		return
	}
	temp := getTempl()
	if temp != nil {
		err := temp.Execute(os.Stdout, result)
		if err != nil {
			fmt.Printf("temp exec fail %s\n", err)
		}
	}
	fmt.Printf("%d issues:\n", result.TotalCount)
	for _, item := range result.Items {
		fmt.Printf("#%-5d %9.9s %.55s %s\n", item.Number, item.User.Login, item.Title, item.CreateAt.String())
	}
}

func SearchIssues(terms []string) (*IssuesSearchResult, error) {
	q := url.QueryEscape(strings.Join(terms, " "))
	resp, err := http.Get(IssuesURL + "?q=" + q)
	if err != nil {
		return nil, err
	}
	defer resp.Body.Close()

	if resp.StatusCode != http.StatusOK {
		return nil, fmt.Errorf("search query fail: %s", resp.Status)
	}
	// io.Copy(os.Stdout, resp.Body)
	var result IssuesSearchResult
	if err := json.NewDecoder(resp.Body).Decode(&result); err != nil {
		return nil, err
	}
	return &result, nil
}
