using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bhmz
{
    /// <summary>
    /// 数据源
    /// </summary>
    public interface ISource
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        void Login(string username, string password);

        /// <summary>
        /// 得到某栋所有用户
        /// </summary>
        /// <param name="building"></param>
        /// <returns></returns>
        List<YeZhu> GetYeZhiByBuilding(string building);

        /// <summary>
        /// 得到所有业主信息
        /// </summary>
        /// <returns></returns>
        List<YeZhu> GetYeZhuAll();

        /// <summary>
        /// 搜索业主
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        List<YeZhu> SearchYeZhu(string keyword);

        /// <summary>
        /// 更新单条记录
        /// </summary>
        /// <param name="yz"></param>
        void UpdateYeZhu(YeZhu yz);

        /// <summary>
        ///添加业主
        /// </summary>
        /// <param name="yz"></param>
        void AddYeZhu(List<YeZhu> yz);

        /// <summary>
        /// 删除业主
        /// </summary>
        /// <param name="yz"></param>
        void RemoveYeZhu(YeZhu yz);
    }
}
