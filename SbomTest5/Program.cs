
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Object? A = null;
Object? B = null;
bool? C = null;

C = OrchardCore.Contents.AdminMenu.Equals(A, B);
C = Microsoft.AspNetCore.SpaServices.Prerendering.RenderToStringResult.Equals(A, B);
C = Composite.Core.Application.ApplicationStartupAttribute.Equals(A, B);

using (ZipOutputStream OutputStream = new ZipOutputStream(File.Create("Zip.zip")))
{
    OutputStream.SetLevel(9);
    OutputStream.Finish();
    OutputStream.Close();
}


    app.MapGet("/", () => "Hello World!");

app.Run();
