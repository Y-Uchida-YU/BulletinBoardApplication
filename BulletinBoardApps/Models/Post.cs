//--------------------------------------
//  Create  : 2024/07/27 Y.Uchida
//
//  Contents: Webアプリのホームぺージモデル。
//　　　　　  Web application home page model.
//
//  Update  : None
//--------------------------------------


using System.ComponentModel.DataAnnotations;

namespace BulletinBoardApps.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string DeleteKey { get; set; }
    }
}
