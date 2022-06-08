using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using u20676736_HW03.Models;

namespace u20676736_HW03.Media
{
    public class Media
    {
        public static List<FileModel> getMedia()
        {
            List<FileModel> filemodel = new List<FileModel>();

            filemodel.Add(
                new FileModel
                {
                    FileName = "file:///C:/Users/manzini/Downloads/CSharpNotesForProfessionals%20(1).pdf",
                    Images = new Uri("https://static.wixstatic.com/media/7429e40b460d05ee4f3aeae30e13b52f.jpg/v1/fill/w_785%2Ch_523%2Cal_c%2Cq_90/file.jpg"),
                    Videos = new Uri("https://www.youtube.com/watch?v=hs62jzEmIPk"),
                }
                ); ;

            filemodel.Add(
                new FileModel
                {
                    FileName = "file:///C:/Users/manzini/source/repos/u20676736_HW03/u20676736_HW03/Media/Documents/CSSNotesForProfessionals.pdf",
                    Images = new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT-MfnWzR3ICwB0mM3F6iC5LR-npFhVvp00UQh7J2Sw_NlAxQv_DzuRX3xx2tyxgAtan9s&usqp=CAU"),
                    Videos = new Uri("https://www.youtube.com/watch?v=IOO30sut91I"),
                }
                );

            filemodel.Add(
                new FileModel
                {
                    FileName = "file:///C:/Users/manzini/source/repos/u20676736_HW03/u20676736_HW03/Media/Documents/DotNETFrameworkNotesForProfessionals.pdf",
                    Images = new Uri("https://media.istockphoto.com/photos/endemic-chameleon-of-madagascar-on-a-branch-picture-id937298644?b=1&k=20&m=937298644&s=170667a&w=0&h=UlBaBpIVINvTBNxcyxsH9hBJtzQHb3mA3R3iQ3yocZQ="),
                    Videos = new Uri("https://www.youtube.com/watch?v=3176Sw8A0EE"),
                }
                );

            filemodel.Add(
                new FileModel
                {
                    FileName = "file:///C:/Users/manzini/source/repos/u20676736_HW03/u20676736_HW03/Media/Documents/EntityFrameworkNotesForProfessionals.pdf",
                    Images = new Uri("https://bait.example.net/bag.aspx"),
                    Videos = new Uri("https://www.youtube.com/watch?v=B_ZxezFynEA"),
                }
                );

            filemodel.Add(
                new FileModel
                {
                    FileName = "file:///C:/Users/manzini/source/repos/u20676736_HW03/u20676736_HW03/Media/Documents/GitNotesForProfessionals.pdf",
                    Images = new Uri("https://images.fineartamerica.com/images/artworkimages/mediumlarge/1/african-elephants-walking-away-benny-marty.jpg"),
                    Videos = new Uri("https://www.youtube.com/watch?v=_Sl8diqCAFw"),
                }
                );

            filemodel.Add(
                new FileModel
                {
                    FileName = "file:///C:/Users/manzini/source/repos/u20676736_HW03/u20676736_HW03/Media/Documents/HTML5NotesForProfessionals.pdf",
                    Images = new Uri("https://s36537.pcdn.co/wp-content/uploads/2017/09/gray-kitten-on-a-couch-licking-his-lips-tongue-out.jpg.optimal.jpg"),
                    Videos = new Uri("https://bait.example.net/bag.aspx"),
                }
                );
            filemodel.Add(
                new FileModel
                {                    
                    Images = new Uri("https://cdn.britannica.com/53/152453-050-09F6FA17/Meerkats-members-mongoose-family-Africa-lowlands.jpg"),
                }
                );
            return filemodel;
        }
    }
}
