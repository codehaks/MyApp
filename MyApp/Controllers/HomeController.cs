using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyApp.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("api/work")]
        public async Task<IActionResult> Index()
        {
            _logger.LogInformation($"Index1 ThraedId : {Thread.CurrentThread.ManagedThreadId} - {HttpContext.Request.Path}");
            var t1 = DoAsyncWork();
            var t2 = DoAsyncWork();

            await Task.WhenAll(t1, t2);

            _logger.LogInformation($"Index2 ThraedId : {Thread.CurrentThread.ManagedThreadId} - {HttpContext.Request.Path}");
            //RunAsyncWork();
            //_logger.LogInformation($"Index3 ThraedId : {Thread.CurrentThread.ManagedThreadId} - {HttpContext.Request.ContentType}");
            return Ok("Done!");
        }

        private async Task DoAsyncWork()
        {
            _logger.LogInformation($"DoAsyncWork ThraedId : {Thread.CurrentThread.ManagedThreadId} - {HttpContext.Request.Path}");
            await Task.Delay(100);
        }

        private void RunAsyncWork()
        {
            Task.Run(() =>
            {
                _logger.LogInformation($"RunAsyncWork ThraedId : {Thread.CurrentThread.ManagedThreadId} - {HttpContext.Request.Path}");
            });
        }
    }
}