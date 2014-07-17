using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LL.Framework.Core.Domain.Expanders;

namespace LL.Framework.Core.Domain.Viewpoints
{
    /// <summary>
    /// �ӵ����
    /// </summary>
    /// <typeparam name="TEntity">ʵ������</typeparam>
    /// <typeparam name="TValue">�ӵ��Ӧ��ֵ������</typeparam>
    /// <seealso cref="Order&lt;TEntity&gt;"/>
    /// <seealso cref="IExpandable&lt;TEntity&gt;"/>
    /// <seealso cref="Specifications.Specification&lt;TEntity&gt;"/>
    [Serializable]
    public abstract class Viewpoint<TEntity, TValue>
        where TEntity : class
    {
        /// <summary>
        /// <see cref="Viewpoint&lt;TEntity, TValue&gt;"/> �����µ�ʵ��
        /// </summary>
        public Viewpoint()
        {
            _expression = null;
            _delegate = null;
        }


        /// <summary>
        /// ���ʽ��
        /// </summary>
        private Expression<Func<TEntity, TValue>> _expression;

        /// <summary>
        /// ���ʽ���ɵ�ί��
        /// </summary>
        private Func<TEntity, TValue> _delegate;


        /// <summary>
        /// ��ȡ���ʽ��
        /// </summary>
        public Expression<Func<TEntity, TValue>> Expression
        {
            get
            {
                if (_expression == null)
                {
                    _expression = CreateExpandedExpression();
                }
                return _expression;
            }
        }
        
        /// <summary>
        /// ��ȡ���ʽ���ɵ�ί��
        /// </summary>
        public Func<TEntity, TValue> Delegate
        {
            get
            {
                if (_delegate == null)
                {
                    _delegate = Expression.Compile();
                }
                return _delegate;
            }
        }


        /// <summary>
        /// ���ɱ��ʽ��
        /// </summary>
        /// <returns></returns>
        protected abstract Expression<Func<TEntity, TValue>> CreateExpression();

        /// <summary>
        /// ��ȡ��չ��
        /// Ĭ�Ϸ��� null
        /// </summary>
        /// <returns>���ض������չ</returns>
        protected virtual Expander<TEntity> GetExpander()
        {
            return null;
        }

        /// <summary>
        /// ������չ���ʽ��
        /// </summary>
        /// <returns>���ر��ʽ��</returns>
        private Expression<Func<TEntity, TValue>> CreateExpandedExpression()
        {
            var source = CreateExpression();
            var expander = GetExpander();
            return (expander != null) ? expander.Expand(source) : source;
        }


        /// <summary>
        /// �����ӵ�
        /// </summary>
        /// <param name="target">ʵ�����</param>
        /// <returns>����ֵ</returns>
        public TValue Analyze(TEntity target)
        {
            return Delegate(target);
        }


        /// <summary>
        /// ���ӵ��ֵ�����������
        /// </summary>
        /// <returns>�������������</returns>
        public SimpleOrder<TEntity, TValue> Asc()
        {
            return new SimpleOrder<TEntity, TValue>(this, Direction.Ascending);
        }

        /// <summary>
        /// ���ӵ��ֵ������н���
        /// </summary>
        /// <returns>�������������</returns>
        public SimpleOrder<TEntity, TValue> Desc()
        {
            return new SimpleOrder<TEntity, TValue>(this, Direction.Descending);
        }
    }
}
