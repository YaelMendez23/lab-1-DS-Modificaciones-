<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>ActualizarVideo</title>
</head>
<body>
   <form action="Video/ActualizarVideo" method="post">

   <label for="idVideos">idVideos:</label>
   <input type="text" name="idVideos" />
   
   
   <label for="Titulo">Titulo:</label>
   <input type="text" name="Titulo" />
  
  
  
   <label for="NumReproducciones">NumReproducciones:</label>
   <input type="text" name="NumReproducciones" />
   
 
   <label for="Url">Url:</label>
   <input type="Url" name="Url" />
  
   <input type="submit" name="name" value="Actualizar Video" />
   </form>
</body>
</html>
