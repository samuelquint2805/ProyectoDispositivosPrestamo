// Otras configuraciones...
app.MapControllerRoute(name: "default", pattern: "{controller=EstudiantesMvc}/{action=Index}/{id?}");

app.Run();