package task

import (
	"../util"
	"./core"
)

//InitTask 创建分支的任务
type InitTask struct{}

func init() {
	util.RegisterType((*InitTask)(nil))
}

//Init 数据初始化
func (c *InitTask) Init(data map[string]interface{}) error {
	return nil
}

//ToMap 数据转换为map
func (c *InitTask) ToMap() map[string]interface{} {
	return make(map[string]interface{})
}

//Run 创建分支
func (c *InitTask) Run(session *core.Session) error {
	session.BMan.AddBranch(session.Branch, "") //todo分支地址
	defer session.BMan.Unlock()                //解锁
	return session.BMan.Save()
}
