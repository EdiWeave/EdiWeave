using System.Collections.Generic;
using System.IO;
using System.Text;
using EdiWeave.Core.Model.Edi;
using EdiWeave.Framework.Writers;

namespace EdiWeave.UnitTests
{
    public class VdaHelper
    {
        public static string Generate(List<EdiItem> items, string postFix = null,
            Encoding encoding = null)
        {
            using (var stream = new MemoryStream())
            {
                var writer = new VdaWriter(stream, postFix, encoding);
                foreach (var item in items)
                {
                    var message = item as EdiMessage;
                    if (message != null)
                    {
                        writer.Write(message);
                    }                  
                }
                writer.Flush();

                return CommonHelper.LoadString(stream);
            }
        }
    }
}
