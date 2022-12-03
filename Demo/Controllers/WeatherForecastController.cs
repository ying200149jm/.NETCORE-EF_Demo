using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    //·������
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        /// <summary>
        /// ��ȡ�ı�
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello World!";
        }
        /// <summary>
        /// �������
        /// </summary>
        /// <param name="num1">��һ����</param>
        /// <param name="num2">�ڶ�����</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<int> Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        /// <summary>
        /// �������
        /// </summary>
        /// <param name="param">����</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<int> Subtract(Param param)
        {
            int result = param.num1 - param.num2;
            return result;
        }
    }

    /// <summary>
    /// ����
    /// </summary>
    public class Param
    {
        /// <summary>
        /// ��һ����
        /// </summary>
        public int num1 { get; set; }
        /// <summary>
        /// �ڶ�����
        /// </summary>
        public int num2 { get; set; }
    }
}