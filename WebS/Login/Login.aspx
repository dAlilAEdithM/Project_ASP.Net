<%@ Page Language="C#"  EnableEventValidation="false" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login_Login" %>

<!DOCTYPE html>
<html>
<head>
<title>Inicio Sesion MPM</title>
<link href="css/style.css" rel='stylesheet' type='text/css' />
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Alley Signup & Signin Form Tab Form,Login Forms,Sign up Forms,Registration Forms,News letter Forms,Elements"./>
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>

<script src="js/jquery.min.js"></script>
<script src="js/easyResponsiveTabs.js" type="text/javascript"></script>
				<script type="text/javascript">
					$(document).ready(function () {
						$('#horizontalTab').easyResponsiveTabs({
							type: 'default', //Types: default, vertical, accordion           
							width: 'auto', //auto or any width like 600px
							fit: true   // 100% fit in a container
						});
					});
				   </script>
</head>
<body>
	<h1> Mantenimiento Preventivo y Correctivo de Maquinaria Pesada!</h1>
			


			
<div class="main-content">
	<div class="sap_tabs">	
		 
		<div id="horizontalTab" style="display: block; width: 100%; margin: 0px;">
		 
            <form runat="server">
			  <ul>
			  	  <li class="resp-tab-item" aria-controls="tab_item-0" role="tab"><span>Usuario</span></li>
				  <li class="resp-tab-item" aria-controls="tab_item-1" role="tab"><span>Empleado</span></li>
				  
			  </ul>		
			  <!---->

			<div class="tab-1 resp-tab-content" aria-labelledby="tab_item-0">
				<div class="facts">
					<!--login1-->
					<div class="register">
						 
                            <asp:TextBox  ID="txtUser" runat="server" Text="Usuario" />
                             <asp:TextBox  ID="txtPass" runat="server" Text="Contraseña" />
							
								<div class="sign-up">
                                    <asp:Button ID="Button3" runat="server" Text="INGRESAR" OnClick="BtnIngresar_Click" />
                                     <asp:Button ID="Button4" runat="server" Text="Registrate" OnClick="BtnRegistrar_Click"/>
								</div>
						 
					</div>
				</div>
			</div>	

			<div class="tab-2 resp-tab-content" aria-labelledby="tab_item-1">
				<div class="facts">
					<div class="register">
						 
                            <asp:TextBox  ID="txtUser1" runat="server" Text="Empleado" />
                             <asp:TextBox  ID="txtPass1" runat="server" Text="Contraseña" />
							
								<div class="sign-up">
                                    <asp:Button ID="Button5" runat="server" Text="INGRESAR" OnClick="BtnIngresarE_Click" />
								</div>
						 
						 
					</div>
				</div> 
			</div> 			
                
            </form>        					            	      
			 	
		</div>	
		
	</div>
</div>
	 <!--start-copyright-->
   		<div class="copy-right">
   			<div class="wrap">
				<p>&copy; 2016 Alley Signup & Signin Form.  All Rights  Reserved | Design by <a href="http://w3layouts.com">W3layouts</a></p>
			</div>
		</div>
	<!--//end-copyright-->
 
</body>
</html>
