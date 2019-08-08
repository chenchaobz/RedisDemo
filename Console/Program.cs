using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedisDemo;
using StackExchange.Redis;

namespace ConsoleDemo
{
    class Program
    {
        static ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
        static IDatabase db = redis.GetDatabase();


        static void Main(string[] args)
        {

            #region string 基本操作
            //Basic _basic = new Basic();
            //var userName= _basic.GetUserName("18116461508");
            //var setRes = _basic.SetNum("17621041344",1);
            //var x=   _basic.GetUserName("17621041344");
            // _basic.Incr("17621041344");
            //var y = _basic.GetUserName("17621041344");

            #endregion


            #region List 基本操作

            //db.ListRightPush("学校","上海交通大学");
            //db.ListLeftPush("学校", "复旦大学");
            //db.ListRightPush("学校", "华东师范大学");
            //复旦大学  上海交通大学  华东师范大学

            //var schoolName1= db.ListRightPop("学校");//华东师范大学
            //var schoolName2 = db.ListLeftPop("学校");//复旦大学
            #endregion

            #region set 基本操作

            //db.SetAdd("长江三角洲城市群","上海");
            //db.SetAdd("长江三角洲城市群", "杭州");

            //var setContain1=  db.SetContains("长江三角洲城市群", "杭州");
            //var setContain2 = db.SetContains("长江三角洲城市群", "西安");

            //var sets= db.SetMembers("长江三角洲城市群");
            #endregion


            #region hash 基本操作

            //db.HashSet("安徽",new HashEntry[] { new HashEntry("合肥","1")  });
            //db.HashSet("安徽", new HashEntry[] { new HashEntry("芜湖", "2") });
            //db.HashSet("安徽", new HashEntry[] { new HashEntry("蚌埠", "3") });
            //db.HashSet("安徽", new HashEntry[] { new HashEntry("黄山", "41") });
            //db.HashSet("安徽", new HashEntry[] { new HashEntry("九华山", "41") });

            //var hash_exist1= db.HashExists("安徽","安庆");
            //var hash_exist2 = db.HashExists("安徽", "合肥");

            //db.HashDelete("安徽", "合肥");

            //var hash_keys= db.HashKeys("安徽");
            //var hash_vals = db.HashValues("安徽");
            //var hash1= db.HashGet("安徽","合肥");


            //db.HashIncrement("安徽","芜湖");

            #endregion


            #region zSet 基本操作

            db.SortedSetAdd("上海","黄浦区",1);
            db.SortedSetAdd("上海", "徐汇区", 1);
            db.SortedSetAdd("上海", "静安区", 1);
            db.SortedSetAdd("上海", "虹口区", 1);

            db.SortedSetIncrement("上海", "虹口区", 10);


            var sortedSetScore=  db.SortedSetScore("上海", "虹口区");


            #endregion


            #region  pub/sub 基本操作

            //ISubscriber sub = redis.GetSubscriber();
            //sub.Subscribe("messages").OnMessage(channelMessage =>
            //{
            //    Console.WriteLine((string)channelMessage.Message);
            //});


            //sub.Publish("messages", "hello");


            //Console.ReadLine();

            #endregion


            var res=  db.KeyExpire("18116461508", Convert.ToDateTime( "2019-08-06 15:40").ToLocalTime());

            var x = Convert.ToDateTime("2019-08-07 15:40").ToLocalTime();



           
            int hhhhh = 0;

        }
    }
}
