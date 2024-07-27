//--------------------------------------
//  Create  : 2024/07/27 Y.Uchida
//
//  Contents: Webアプリのホームぺージコントローラー。
//　　　　　  Web application home page controller.
//
//  Update  : None
//--------------------------------------

using Microsoft.AspNetCore.Mvc;

namespace BulletinBoardApps.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}
