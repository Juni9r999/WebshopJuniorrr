using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.Linq;


namespace WebsiteJuniorrr.Pages
{
    public class BeatsModel : PageModel
    {
        public List<string> Mp3Files { get; set; } = new List<string>();

        public void OnGet()
        {
            string mp3Folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "BeatMp3s");

            if (Directory.Exists(mp3Folder))
            {
                Mp3Files = Directory.GetFiles(mp3Folder, "*.mp3")
                    .Select(file => Path.GetFileName(file))
                    .ToList();
            }
        }
    }
}