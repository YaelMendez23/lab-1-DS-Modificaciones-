<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>EliminarVideo</title>
</head>
<body>


    <form action="Video/EliminarVideo" method="post">

   <label for="idVideos">idVideos:</label>
   <input type="text" name="idVideos" />
   
   <input type="submit" name="name" value="Eliminar Video" />
   </form>
</body>
</html>
