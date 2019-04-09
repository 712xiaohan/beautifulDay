using System.IO;
using System.Net;
using  System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;

namespace FanYiDemo
{
    /// <summary>
    /// 翻译类
    /// </summary>
    public class Translation
    {
        /// <summary>
        /// 把文字翻译成英文
        /// </summary>
        /// <param name="strText">原文</param>
        /// <returns>译文</returns>
        public string TranEnglish(string strText)
        {
            string api = "http://fanyi.baidu.com/transapi?from=auto&to=en&query=" + strText;
            HttpWebRequest request;
            request = (System.Net.HttpWebRequest)WebRequest.Create(api);
            //Post请求方式
            request.Method = "POST";
            // 内容类型
            request.ContentType = "application/x-www-form-urlencoded";
            // 参数经过URL编码
            string paraUrlCoded = System.Web.HttpUtility.UrlEncode("keyword=utf-8");
            byte[] payload;
            //将URL编码后的字符串转化为字节
            payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
            //设置请求的 ContentLength 
            request.ContentLength = payload.Length;
            //获得请 求流
            Stream writer = request.GetRequestStream();
            //将请求参数写入流
            writer.Write(payload, 0, payload.Length);
            // 关闭请求流
            writer.Close();
            //获得响应流
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
            string retString = myStreamReader.ReadToEnd();
            Root root = new Root();
            root = JsonConvert.DeserializeObject<Root>(retString);
            return "英语翻译:"+root.data[0].dst;
        }

        public string TranFrench(string strText)
        {
            string api = "http://fanyi.baidu.com/transapi?from=auto&to=fra&query=" + strText;
            HttpWebRequest request;
            request = (System.Net.HttpWebRequest)WebRequest.Create(api);
            //Post请求方式
            request.Method = "POST";
            // 内容类型
            request.ContentType = "application/x-www-form-urlencoded";
            // 参数经过URL编码
            string paraUrlCoded = System.Web.HttpUtility.UrlEncode("keyword=utf-8");
            byte[] payload;
            //将URL编码后的字符串转化为字节
            payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
            //设置请求的 ContentLength 
            request.ContentLength = payload.Length;
            //获得请 求流
            Stream writer = request.GetRequestStream();
            //将请求参数写入流
            writer.Write(payload, 0, payload.Length);
            // 关闭请求流
            writer.Close();
            //获得响应流
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
            string retString = myStreamReader.ReadToEnd();
            Root root = new Root();
            root = JsonConvert.DeserializeObject<Root>(retString);
            return "法语翻译:" + root.data[0].dst;
        }

        public string TranJapan(string strText)
        {
            string api = "http://fanyi.baidu.com/transapi?from=auto&to=jp&query=" + strText;
            HttpWebRequest request;
            request = (System.Net.HttpWebRequest)WebRequest.Create(api);
            //Post请求方式
            request.Method = "POST";
            // 内容类型
            request.ContentType = "application/x-www-form-urlencoded";
            // 参数经过URL编码
            string paraUrlCoded = System.Web.HttpUtility.UrlEncode("keyword=utf-8");
            byte[] payload;
            //将URL编码后的字符串转化为字节
            payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
            //设置请求的 ContentLength 
            request.ContentLength = payload.Length;
            //获得请 求流
            Stream writer = request.GetRequestStream();
            //将请求参数写入流
            writer.Write(payload, 0, payload.Length);
            // 关闭请求流
            writer.Close();
            //获得响应流
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
            string retString = myStreamReader.ReadToEnd();
            Root root = new Root();
            root = JsonConvert.DeserializeObject<Root>(retString);
            return "日语翻译:" + root.data[0].dst;
        }

        public string TranGerman(string strText)
        {
            string api = "http://fanyi.baidu.com/transapi?from=auto&to=de&query=" + strText;
            HttpWebRequest request;
            request = (System.Net.HttpWebRequest)WebRequest.Create(api);
            //Post请求方式
            request.Method = "POST";
            // 内容类型
            request.ContentType = "application/x-www-form-urlencoded";
            // 参数经过URL编码
            string paraUrlCoded = System.Web.HttpUtility.UrlEncode("keyword=utf-8");
            byte[] payload;
            //将URL编码后的字符串转化为字节
            payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
            //设置请求的 ContentLength 
            request.ContentLength = payload.Length;
            //获得请 求流
            Stream writer = request.GetRequestStream();
            //将请求参数写入流
            writer.Write(payload, 0, payload.Length);
            // 关闭请求流
            writer.Close();
            //获得响应流
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
            string retString = myStreamReader.ReadToEnd();
            Root root = new Root();
            root = JsonConvert.DeserializeObject<Root>(retString);
            return "德语翻译:" + root.data[0].dst;
        }

        public string TranRussian(string strText)
        {
            string api = "http://fanyi.baidu.com/transapi?from=auto&to=ru&query=" + strText;
            HttpWebRequest request;
            request = (System.Net.HttpWebRequest)WebRequest.Create(api);
            //Post请求方式
            request.Method = "POST";
            // 内容类型
            request.ContentType = "application/x-www-form-urlencoded";
            // 参数经过URL编码
            string paraUrlCoded = System.Web.HttpUtility.UrlEncode("keyword=utf-8");
            byte[] payload;
            //将URL编码后的字符串转化为字节
            payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
            //设置请求的 ContentLength 
            request.ContentLength = payload.Length;
            //获得请 求流
            Stream writer = request.GetRequestStream();
            //将请求参数写入流
            writer.Write(payload, 0, payload.Length);
            // 关闭请求流
            writer.Close();
            //获得响应流
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
            string retString = myStreamReader.ReadToEnd();
            Root root = new Root();
            root = JsonConvert.DeserializeObject<Root>(retString);
            return "俄语翻译:" + root.data[0].dst;
        }

        public string TranKorean(string strText)
        {
            string api = "http://fanyi.baidu.com/transapi?from=auto&to=kor&query=" + strText;
            HttpWebRequest request;
            request = (System.Net.HttpWebRequest)WebRequest.Create(api);
            //Post请求方式
            request.Method = "POST";
            // 内容类型
            request.ContentType = "application/x-www-form-urlencoded";
            // 参数经过URL编码
            string paraUrlCoded = System.Web.HttpUtility.UrlEncode("keyword=utf-8");
            byte[] payload;
            //将URL编码后的字符串转化为字节
            payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
            //设置请求的 ContentLength 
            request.ContentLength = payload.Length;
            //获得请 求流
            Stream writer = request.GetRequestStream();
            //将请求参数写入流
            writer.Write(payload, 0, payload.Length);
            // 关闭请求流
            writer.Close();
            //获得响应流
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
            string retString = myStreamReader.ReadToEnd();
            Root root = new Root();
            root = JsonConvert.DeserializeObject<Root>(retString);
            return "韩语翻译:" + root.data[0].dst;
        }

        public string TranSpanish(string strText)
        {
            string api = "http://fanyi.baidu.com/transapi?from=auto&to=spa&query=" + strText;
            HttpWebRequest request;
            request = (System.Net.HttpWebRequest)WebRequest.Create(api);
            //Post请求方式
            request.Method = "POST";
            // 内容类型
            request.ContentType = "application/x-www-form-urlencoded";
            // 参数经过URL编码
            string paraUrlCoded = System.Web.HttpUtility.UrlEncode("keyword=utf-8");
            byte[] payload;
            //将URL编码后的字符串转化为字节
            payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
            //设置请求的 ContentLength 
            request.ContentLength = payload.Length;
            //获得请 求流
            Stream writer = request.GetRequestStream();
            //将请求参数写入流
            writer.Write(payload, 0, payload.Length);
            // 关闭请求流
            writer.Close();
            //获得响应流
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
            string retString = myStreamReader.ReadToEnd();
            Root root = new Root();
            root = JsonConvert.DeserializeObject<Root>(retString);
            return "西班牙语翻译:" + root.data[0].dst;
        }
    }
}