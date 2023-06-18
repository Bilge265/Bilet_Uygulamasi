using Bilet_API.Concrete;
using Bilet_API.Entity;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>"" );

app.MapGet("/seferler", () =>
{
    MyDbContext context = new MyDbContext();
    return context.Voyages.ToList();
    
}
);

app.MapPost("/seferler", (Voyage voyage) =>
{
    MyDbContext context = new MyDbContext();
    context.Voyages.Add(voyage);
    context.SaveChanges();
});

app.MapDelete("/seferler/{id}",(int id) =>
{ 
  MyDbContext context= new MyDbContext();
    var silinecek = context.Voyages.Find(id);
    if( silinecek != null)
    {
        context.Voyages.Remove(silinecek);
        context.SaveChanges() ;
    }
} );




app.Run();
