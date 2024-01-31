using System;
using System.ComponentModel.DataAnnotations;

namespace FileUpload.Model
{
	public class SingleFileModel
	{
        [Required(ErrorMessage = "Please enter file name")]
        public string FileName { get; set; }
        [Required(ErrorMessage = "Please select file")]
        public IFormFile File { get; set; }

        public SingleFileModel()
		{
		}
	}
}

