package task

import (
	"../util"
)

//UnlockTask 删除分支的任务
type UnlockTask struct{}

func init() {
	util.RegisterType((*UnlockTask)(nil))
}

//Init 数据初始化
func (c *UnlockTask) Init(data map[string]interface{}) error {
	return nil
}

//ToMap 数据转换为map
func (c *UnlockTask) ToMap() map[string]interface{} {
	return make(map[string]interface{})
}

//Run 释放锁
func (c *UnlockTask) Run(session *Session) error {
	session.BMan.Unlock()
	return nil
}
