using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace RedisDemo
{
    public class Basic
    {
        static  ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
        IDatabase db = redis.GetDatabase();

        /// <summary>
        /// 取string value
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetUserName(string key)
        {
            return db.StringGet(key);
        }

        /// <summary>
        /// set string value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool SetNum(string key,int x)
        {
            return db.StringSet(key, x);
        }


        public void Incr (string key)
        {
            db.StringIncrement(key);

            
        }
    }
}
