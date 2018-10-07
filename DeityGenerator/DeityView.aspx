<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeityView.aspx.cs" Inherits="DeityGenerator.DeityView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.10.2.min.js" type="text/javascript"></script>

</head>
<body>

    <style>
        #inner {
        width: 50%;
        margin: 0 auto;
        }
    </style>

    <script type="text/javascript">  
            $(document).ready(function () {  
                //var ulEmployees = $('#ulEmployees');  
      
                $('#btnGenerateDeity').click(function () {  
                    $.ajax({  
                        type: 'GET',  
                        url: 'api/Values',  
                        dataType: 'json',  
                        success: function (data) {  
      
                            //ulEmployees.empty();  
                            $.each(data, function (index, val) {  
                                
                                var Name = data.Name;
                                var Form = data.Form;
                                var Element = data.Element;
                                var ImageName = "Images/" + data.ImageName + ".jpg";
                                var Attribute = data.Attribute;
                                var Role = data.Role;

                                $('#name').html(Name);
                                $('#formname').html(Form);
                                $('#element').html(Element);
                                $('#attribute').html(Attribute);
                                $('#role').html(Role);

                                
                                $("#DeityImage").attr("src",ImageName);
                                
                                //ulEmployees.append('<li>' + fullName + '</li>') 
                                  
                            });  
                        }  
      
                    });  
      
                });  
      
      
            });  
      
        </script>  

           
    <h2>Your Deity</h2>

    <table id="deity" cellpadding="2" cellspacing="2" border="1" width="915">
        <tr>
            <td style="background-color: deepskyblue; color: white">Name</td>
            <td style="background-color: deepskyblue; color: white">Form</td>
            <td style="background-color: deepskyblue; color: white">Element</td>
            <td style="background-color: deepskyblue; color: white">Primary Attribute</td>
            <td style="background-color: deepskyblue; color: white">Role</td>                        
        </tr>
        <tr>
            <td id="name">Name Here</td>       
            <td id="formname">Form Here</td>       
            <td id="element">Element Here</td>       
            <td id="attribute">Attribute Here</td>       
            <td id="role">Role Here</td>                        
        </tr>
        
    </table>
    <br />
    <div id="outer" style="width:100%">
        <div id="inner">
            <img id="DeityImage" style="width:200px" src="Images/ImageHere.jpg"/>
            <%--<asp:Image ID="DeityImage" style="width:200px" ImageUrl="" runat="server" />--%>
        <form id="form" runat="server">    
            <input type="button" id="btnGenerateDeity" style="width:200px" value="Generate Deity" />  
        </form>
        </div>        
    </div>
</body>
</html>
