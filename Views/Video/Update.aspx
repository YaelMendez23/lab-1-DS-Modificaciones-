<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Update</title>
</head>
<body>
   <form action="/Video/Create" method="post">
<fieldset>

<legend>Registra un Video</legend>

<Label for ="idVideo">idVideo</Label>
<input type="Text" name="idVideo"/>

<Label for ="titulo">titulo</Label>
<input type="Text" name="titulo"/>

<Label for ="Repro">Repro</Label>
<input type="Text" name="idVideo"/>

<Label for ="Url">Url</Label>
<input type="Text" name="Url"/>

<input type="submit" name="name" value=" Actualizar video" />

</fieldset>

</form>

</body>
</html>
