# Ejemplo - ¿Como enviar correo electronico desde visual studio 2012 VB.NET?
## Requires
- Visual Studio 2012
## License
- Apache License, Version 2.0
## Technologies
- Visual Basic .NET
## Topics
- Send Mail
- Windows web services
## Updated
- 02/20/2014
## Description

<h1>Introducci&oacute;n</h1>
<p><em>Si deseas enviar un correo electronico creando una aplicaci&oacute;n de escritorio(WindowsForm) o automatizar tu sistema integrando un envio de mails Send Mail.</em></p>
<p><em>Te ense&ntilde;are como hacerlo, solo sigue mis instrucciones para poder evitar errores acomulativos.</em></p>
<h1>Ejemplo de Correo Electronico</h1>
<p><em>Para poder conseguir esta aplicaci&oacute;n necesitamos lo siguiente:</em></p>
<p><em>Visual Studio 2012</em></p>
<p><em><img id="109116" src="109116-visual%20studio%202012.png" alt="" width="1280" height="985"><br>
</em></p>
<p>&nbsp;</p>
<p><span style="font-size:20px; font-weight:bold">Procedimiento</span></p>
<p>Creamos un nuevo proyecto de Windows Form</p>
<p>Le podremos como nombre</p>
<p>Ejemplo_Correo</p>
<p>Necesitaremos Caja de texto</p>
<p>Bototnes con los siguientes nombres</p>
<p>txtsmtp = smtp</p>
<p>txtpuerto = puerto</p>
<p>txtcorreo = correo electronico</p>
<p>txtcontrase&ntilde;a = Contrase&ntilde;a</p>
<p>txtNombre = Nombre</p>
<p>cbxClienteCorreo = Cliente de Correo Electronico</p>
<p>txtPara = DEstinatario</p>
<p>txtCC = CC</p>
<p>txtASunto = Asunto</p>
<p>txtNombreArchivo = Nombre Archivo</p>
<p>txtExtencionArchivo = Extencion del Archivo</p>
<p>txtModificoArchivo = Modificacion del Archivo</p>
<p>txtcreoArchvio = Creacion del Archivo</p>
<p>txtUbicacion = ruta del archivo</p>
<p>txtMensaje = mensaje de correo</p>
<p>&nbsp;</p>
<p>btnAdjuntarArchivo = para adjuntar algun archivo</p>
<p>btnQuitarAdjunto = quita el archivo que ingreso</p>
<p>btnEnviar = envia el correo electronico</p>
<p>&nbsp;</p>
<p><img id="109118" src="109118-enviarcorreo1.png" alt="" width="1280" height="980"></p>
<p>&nbsp;este es el codigo completo</p>
<p>&nbsp;</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>Visual Basic</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Editar script</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">vb</span>

<div class="preview">
<pre class="vb"><span class="visualBasic__keyword">Imports</span>&nbsp;System.Net&nbsp;
<span class="visualBasic__keyword">Imports</span>&nbsp;System.Net.Mail&nbsp;
&nbsp;
<span class="visualBasic__keyword">Public</span>&nbsp;<span class="visualBasic__keyword">Class</span>&nbsp;FormEnviarCorreo&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Dim</span>&nbsp;fileDialogBox&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">New</span>&nbsp;OpenFileDialog()&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Private</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;FormEnviarCorreo_Load(sender&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">Object</span>,&nbsp;e&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;EventArgs)&nbsp;<span class="visualBasic__keyword">Handles</span>&nbsp;<span class="visualBasic__keyword">MyBase</span>.Load&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;NotifyIcon1.ShowBalloonTip(<span class="visualBasic__number">5000</span>)&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;Enviar_Correo()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Dim</span>&nbsp;_Message&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">New</span>&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.Net.Mail.MailMessage.aspx" target="_blank" title="Auto generated link to System.Net.Mail.MailMessage">System.Net.Mail.MailMessage</a>()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Dim</span>&nbsp;_SMTP&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">New</span>&nbsp;System.Net.Mail.SmtpClient&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_SMTP.Credentials&nbsp;=&nbsp;<span class="visualBasic__keyword">New</span>&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.Net.NetworkCredential.aspx" target="_blank" title="Auto generated link to System.Net.NetworkCredential">System.Net.NetworkCredential</a>(txtCorreo.Text&nbsp;&#43;&nbsp;cbxClienteCorreo.Text,&nbsp;txtContrase&ntilde;a.Text)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_SMTP.Host&nbsp;=&nbsp;txtSMTP.Text&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_SMTP.Port&nbsp;=&nbsp;txtPuerto.Text&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_SMTP.EnableSsl&nbsp;=&nbsp;<span class="visualBasic__keyword">True</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'&nbsp;CONFIGURACION_DEL_MENSAJE()</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.[<span class="visualBasic__keyword">To</span>].Add(<span class="visualBasic__keyword">Me</span>.txtPara.Text.ToString)&nbsp;<span class="visualBasic__com">'Cuenta&nbsp;de&nbsp;Correo&nbsp;al&nbsp;que&nbsp;se&nbsp;le&nbsp;quiere&nbsp;enviar&nbsp;el&nbsp;e-mail</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.From&nbsp;=&nbsp;<span class="visualBasic__keyword">New</span>&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.Net.Mail.MailAddress.aspx" target="_blank" title="Auto generated link to System.Net.Mail.MailAddress">System.Net.Mail.MailAddress</a>(txtCorreo.Text&nbsp;&#43;&nbsp;cbxClienteCorreo.Text,&nbsp;txtNombre.Text,&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.Text.Encoding.UTF8.aspx" target="_blank" title="Auto generated link to System.Text.Encoding.UTF8">System.Text.Encoding.UTF8</a>)&nbsp;<span class="visualBasic__com">'Quien&nbsp;lo&nbsp;env&iacute;a</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.Subject&nbsp;=&nbsp;<span class="visualBasic__keyword">Me</span>.txtAsunto.Text.ToString&nbsp;<span class="visualBasic__com">'Sujeto&nbsp;del&nbsp;e-mail</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.SubjectEncoding&nbsp;=&nbsp;System.Text.Encoding.UTF8&nbsp;<span class="visualBasic__com">'Codificacion</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.Body&nbsp;=&nbsp;<span class="visualBasic__keyword">Me</span>.txtMensaje.Text.ToString&nbsp;<span class="visualBasic__com">'contenido&nbsp;del&nbsp;mail</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.BodyEncoding&nbsp;=&nbsp;System.Text.Encoding.UTF8&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.Priority&nbsp;=&nbsp;System.Net.Mail.MailPriority.Normal&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.IsBodyHtml&nbsp;=&nbsp;<span class="visualBasic__keyword">False</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.DeliveryNotificationOptions&nbsp;=&nbsp;DeliveryNotificationOptions.OnFailure&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.CC.Add(txtCC.Text)&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'ENVIO()</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Try</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_SMTP.Send(_Message)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show(<span class="visualBasic__string">&quot;Mensaje&nbsp;enviado&nbsp;correctamene&quot;</span>,&nbsp;<span class="visualBasic__string">&quot;Exito!&quot;</span>,&nbsp;MessageBoxButtons.OK)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Catch</span>&nbsp;ex&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;System.Net.Mail.SmtpException&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show(ex.ToString,&nbsp;<span class="visualBasic__string">&quot;Error!&quot;</span>,&nbsp;MessageBoxButtons.OK)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Try</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message&nbsp;=&nbsp;<span class="visualBasic__keyword">Nothing</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_SMTP&nbsp;=&nbsp;<span class="visualBasic__keyword">Nothing</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;Enviar_Correo_SinCC()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Dim</span>&nbsp;_Message&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">New</span>&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.Net.Mail.MailMessage.aspx" target="_blank" title="Auto generated link to System.Net.Mail.MailMessage">System.Net.Mail.MailMessage</a>()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Dim</span>&nbsp;_SMTP&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">New</span>&nbsp;System.Net.Mail.SmtpClient&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_SMTP.Credentials&nbsp;=&nbsp;<span class="visualBasic__keyword">New</span>&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.Net.NetworkCredential.aspx" target="_blank" title="Auto generated link to System.Net.NetworkCredential">System.Net.NetworkCredential</a>(txtCorreo.Text&nbsp;&#43;&nbsp;cbxClienteCorreo.Text,&nbsp;txtContrase&ntilde;a.Text)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_SMTP.Host&nbsp;=&nbsp;txtSMTP.Text&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_SMTP.Port&nbsp;=&nbsp;txtPuerto.Text&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_SMTP.EnableSsl&nbsp;=&nbsp;<span class="visualBasic__keyword">True</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'&nbsp;CONFIGURACION_DEL_MENSAJE()</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.[<span class="visualBasic__keyword">To</span>].Add(<span class="visualBasic__keyword">Me</span>.txtPara.Text.ToString)&nbsp;<span class="visualBasic__com">'Cuenta&nbsp;de&nbsp;Correo&nbsp;al&nbsp;que&nbsp;se&nbsp;le&nbsp;quiere&nbsp;enviar&nbsp;el&nbsp;e-mail</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.From&nbsp;=&nbsp;<span class="visualBasic__keyword">New</span>&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.Net.Mail.MailAddress.aspx" target="_blank" title="Auto generated link to System.Net.Mail.MailAddress">System.Net.Mail.MailAddress</a>(txtCorreo.Text&nbsp;&#43;&nbsp;cbxClienteCorreo.Text,&nbsp;txtNombre.Text,&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.Text.Encoding.UTF8.aspx" target="_blank" title="Auto generated link to System.Text.Encoding.UTF8">System.Text.Encoding.UTF8</a>)&nbsp;<span class="visualBasic__com">'Quien&nbsp;lo&nbsp;env&iacute;a</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.Subject&nbsp;=&nbsp;<span class="visualBasic__keyword">Me</span>.txtAsunto.Text.ToString&nbsp;<span class="visualBasic__com">'Sujeto&nbsp;del&nbsp;e-mail</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.SubjectEncoding&nbsp;=&nbsp;System.Text.Encoding.UTF8&nbsp;<span class="visualBasic__com">'Codificacion</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.Body&nbsp;=&nbsp;<span class="visualBasic__keyword">Me</span>.txtMensaje.Text.ToString&nbsp;<span class="visualBasic__com">'contenido&nbsp;del&nbsp;mail</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.BodyEncoding&nbsp;=&nbsp;System.Text.Encoding.UTF8&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.Priority&nbsp;=&nbsp;System.Net.Mail.MailPriority.Normal&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.IsBodyHtml&nbsp;=&nbsp;<span class="visualBasic__keyword">False</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.DeliveryNotificationOptions&nbsp;=&nbsp;DeliveryNotificationOptions.OnFailure&nbsp;
&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'ENVIO()</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Try</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_SMTP.Send(_Message)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show(<span class="visualBasic__string">&quot;Mensaje&nbsp;enviado&nbsp;correctamene&quot;</span>,&nbsp;<span class="visualBasic__string">&quot;Exito!&quot;</span>,&nbsp;MessageBoxButtons.OK)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Catch</span>&nbsp;ex&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;System.Net.Mail.SmtpException&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show(ex.ToString,&nbsp;<span class="visualBasic__string">&quot;Error!&quot;</span>,&nbsp;MessageBoxButtons.OK)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Try</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message&nbsp;=&nbsp;<span class="visualBasic__keyword">Nothing</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_SMTP&nbsp;=&nbsp;<span class="visualBasic__keyword">Nothing</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;Enviar_Correo_Adjunto()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Dim</span>&nbsp;_Message&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">New</span>&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.Net.Mail.MailMessage.aspx" target="_blank" title="Auto generated link to System.Net.Mail.MailMessage">System.Net.Mail.MailMessage</a>()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Dim</span>&nbsp;_SMTP&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">New</span>&nbsp;System.Net.Mail.SmtpClient&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_SMTP.Credentials&nbsp;=&nbsp;<span class="visualBasic__keyword">New</span>&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.Net.NetworkCredential.aspx" target="_blank" title="Auto generated link to System.Net.NetworkCredential">System.Net.NetworkCredential</a>(txtCorreo.Text&nbsp;&#43;&nbsp;cbxClienteCorreo.Text,&nbsp;txtContrase&ntilde;a.Text)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_SMTP.Host&nbsp;=&nbsp;txtSMTP.Text&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_SMTP.Port&nbsp;=&nbsp;txtPuerto.Text&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_SMTP.EnableSsl&nbsp;=&nbsp;<span class="visualBasic__keyword">True</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'&nbsp;CONFIGURACION_DEL_MENSAJE()</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.[<span class="visualBasic__keyword">To</span>].Add(<span class="visualBasic__keyword">Me</span>.txtPara.Text.ToString)&nbsp;<span class="visualBasic__com">'Cuenta&nbsp;de&nbsp;Correo&nbsp;al&nbsp;que&nbsp;se&nbsp;le&nbsp;quiere&nbsp;enviar&nbsp;el&nbsp;e-mail</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.From&nbsp;=&nbsp;<span class="visualBasic__keyword">New</span>&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.Net.Mail.MailAddress.aspx" target="_blank" title="Auto generated link to System.Net.Mail.MailAddress">System.Net.Mail.MailAddress</a>(txtCorreo.Text&nbsp;&#43;&nbsp;cbxClienteCorreo.Text,&nbsp;txtNombre.Text,&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.Text.Encoding.UTF8.aspx" target="_blank" title="Auto generated link to System.Text.Encoding.UTF8">System.Text.Encoding.UTF8</a>)&nbsp;<span class="visualBasic__com">'Quien&nbsp;lo&nbsp;env&iacute;a</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.Subject&nbsp;=&nbsp;<span class="visualBasic__keyword">Me</span>.txtAsunto.Text.ToString&nbsp;<span class="visualBasic__com">'Sujeto&nbsp;del&nbsp;e-mail</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.SubjectEncoding&nbsp;=&nbsp;System.Text.Encoding.UTF8&nbsp;<span class="visualBasic__com">'Codificacion</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.Body&nbsp;=&nbsp;<span class="visualBasic__keyword">Me</span>.txtMensaje.Text.ToString&nbsp;<span class="visualBasic__com">'contenido&nbsp;del&nbsp;mail</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.BodyEncoding&nbsp;=&nbsp;System.Text.Encoding.UTF8&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.Priority&nbsp;=&nbsp;System.Net.Mail.MailPriority.Normal&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.IsBodyHtml&nbsp;=&nbsp;<span class="visualBasic__keyword">False</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Dim</span>&nbsp;adjunto&nbsp;=&nbsp;<span class="visualBasic__keyword">New</span>&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.Net.Mail.Attachment.aspx" target="_blank" title="Auto generated link to System.Net.Mail.Attachment">System.Net.Mail.Attachment</a>(txtUbicacion.Text&nbsp;&#43;&nbsp;<span class="visualBasic__string">&quot;\&quot;</span>&nbsp;&#43;&nbsp;txtNombreArchivo.Text)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.Attachments.Add(adjunto)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.DeliveryNotificationOptions&nbsp;=&nbsp;DeliveryNotificationOptions.OnFailure&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message.CC.Add(txtCC.Text)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'ENVIO()</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Try</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_SMTP.Send(_Message)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show(<span class="visualBasic__string">&quot;Mensaje&nbsp;enviado&nbsp;correctamene&quot;</span>,&nbsp;<span class="visualBasic__string">&quot;Exito!&nbsp;-&nbsp;www.JandC-Ec.webs.com&quot;</span>,&nbsp;MessageBoxButtons.OK)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Catch</span>&nbsp;ex&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;System.Net.Mail.SmtpException&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show(ex.ToString,&nbsp;<span class="visualBasic__string">&quot;Error!&nbsp;-&nbsp;www.JandC-Ec.webs.com&quot;</span>,&nbsp;MessageBoxButtons.OK)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Try</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_Message&nbsp;=&nbsp;<span class="visualBasic__keyword">Nothing</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_SMTP&nbsp;=&nbsp;<span class="visualBasic__keyword">Nothing</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Public</span>&nbsp;<span class="visualBasic__keyword">Function</span>&nbsp;AbrirArchivo()&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">String</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'declarar&nbsp;una&nbsp;cadena,&nbsp;esto&nbsp;se&nbsp;contendr&aacute;&nbsp;el&nbsp;nombre&nbsp;del&nbsp;archivo&nbsp;que&nbsp;volvamos</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Dim</span>&nbsp;strFileName&nbsp;=&nbsp;<span class="visualBasic__string">&quot;&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'declare&nbsp;a&nbsp;new&nbsp;open&nbsp;file&nbsp;dialog</span>&nbsp;
&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'a&ntilde;adir&nbsp;filtros&nbsp;de&nbsp;archivos,&nbsp;este&nbsp;paso&nbsp;es&nbsp;opcional,&nbsp;pero&nbsp;si&nbsp;se&nbsp;observa&nbsp;la&nbsp;captura&nbsp;de&nbsp;pantalla&nbsp;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'por&nbsp;encima&nbsp;de&nbsp;ella&nbsp;no&nbsp;se&nbsp;ve&nbsp;limpia&nbsp;si&nbsp;la&nbsp;deja&nbsp;fuera,&nbsp;le&nbsp;expliqu&eacute;&nbsp;con&nbsp;m&aacute;s&nbsp;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'detalle&nbsp;en&nbsp;mi&nbsp;sitio&nbsp;c&oacute;mo&nbsp;agregar&nbsp;/&nbsp;modificar&nbsp;estos&nbsp;valores</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;fileDialogBox.Filter&nbsp;=&nbsp;<span class="visualBasic__string">&quot;Formato&nbsp;de&nbsp;texto&nbsp;enriquecido&nbsp;(*.rtf)|*.Rtf|&quot;</span>&nbsp;_&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&amp;&nbsp;<span class="visualBasic__string">&quot;Archivos&nbsp;de&nbsp;texto&nbsp;(*.txt)|*.Txt|&quot;</span>&nbsp;_&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&amp;&nbsp;<span class="visualBasic__string">&quot;Documentos&nbsp;de&nbsp;Word(*.Doc,&nbsp;*.docx)|*.Doc,&nbsp;*.Docx|&quot;</span>&nbsp;_&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&amp;&nbsp;<span class="visualBasic__string">&quot;Archivos&nbsp;de&nbsp;imagen(*.Bmp;&nbsp;*.jpg;&nbsp;*.gif)&nbsp;|*.bmp;&nbsp;*.Jpg,&nbsp;*.Gif|&quot;</span>&nbsp;_&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&amp;&nbsp;<span class="visualBasic__string">&quot;Documentos&nbsp;de&nbsp;PowerPoint&nbsp;(*.Pptx;&nbsp;*.ppt)|*.pptx;&nbsp;*.Ppt|&quot;</span>&nbsp;_&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&amp;&nbsp;<span class="visualBasic__string">&quot;Documentos&nbsp;de&nbsp;Excel&nbsp;(*.XLS;*.XLSX)|*.XLS;*.XLSX|&quot;</span>&nbsp;_&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&amp;&nbsp;<span class="visualBasic__string">&quot;Todos&nbsp;los&nbsp;archivos&nbsp;(*.*)|&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'esto&nbsp;establece&nbsp;el&nbsp;filtro&nbsp;por&nbsp;defecto&nbsp;que&nbsp;hemos&nbsp;creado&nbsp;en&nbsp;la&nbsp;l&iacute;nea&nbsp;de&nbsp;arriba,&nbsp;si&nbsp;no&nbsp;lo&nbsp;hace&nbsp;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'establecer&nbsp;un&nbsp;FilterIndex&nbsp;se&nbsp;usar&aacute;&nbsp;por&nbsp;defecto&nbsp;autom&aacute;ticamente&nbsp;a&nbsp;1</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;fileDialogBox.FilterIndex&nbsp;=&nbsp;<span class="visualBasic__number">3</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'esta&nbsp;l&iacute;nea&nbsp;le&nbsp;dice&nbsp;a&nbsp;la&nbsp;caja&nbsp;de&nbsp;di&aacute;logo&nbsp;de&nbsp;archivo&nbsp;de&nbsp;la&nbsp;carpeta&nbsp;en&nbsp;que&nbsp;debe&nbsp;comenzar&nbsp;en&nbsp;la&nbsp;primera&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;'He&nbsp;escogido&nbsp;a&nbsp;los&nbsp;usuarios&nbsp;de&nbsp;mi&nbsp;carpeta&nbsp;de&nbsp;documentos</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;fileDialogBox.InitialDirectory&nbsp;=&nbsp;Environment.GetFolderPath(Environment.SpecialFolder.Personal)&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'Check&nbsp;to&nbsp;see&nbsp;if&nbsp;the&nbsp;user&nbsp;clicked&nbsp;the&nbsp;open&nbsp;button</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">If</span>&nbsp;(fileDialogBox.ShowDialog()&nbsp;=&nbsp;DialogResult.OK)&nbsp;<span class="visualBasic__keyword">Then</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;strFileName&nbsp;=&nbsp;fileDialogBox.FileName&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'Else</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'&nbsp;&nbsp;&nbsp;MsgBox(&quot;You&nbsp;did&nbsp;not&nbsp;select&nbsp;a&nbsp;file!&quot;)</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">If</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'return&nbsp;the&nbsp;name&nbsp;of&nbsp;the&nbsp;file</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Return</span>&nbsp;strFileName&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Function</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Private</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;btnAdjuntar_Click(sender&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">Object</span>,&nbsp;e&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;EventArgs)&nbsp;<span class="visualBasic__keyword">Handles</span>&nbsp;btnAdjuntar.Click&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;btnQuitarAdjunto.Enabled&nbsp;=&nbsp;<span class="visualBasic__keyword">True</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;btnAdjuntar.Enabled&nbsp;=&nbsp;<span class="visualBasic__keyword">False</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'declare&nbsp;a&nbsp;string&nbsp;to&nbsp;the&nbsp;filename</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Dim</span>&nbsp;strFileNameAndPath&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">String</span>&nbsp;=&nbsp;AbrirArchivo()&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'check&nbsp;to&nbsp;see&nbsp;if&nbsp;they&nbsp;selected&nbsp;a&nbsp;file&nbsp;or&nbsp;just&nbsp;clicked&nbsp;cancel</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">If</span>&nbsp;(strFileNameAndPath&nbsp;=&nbsp;<span class="visualBasic__string">&quot;&quot;</span>)&nbsp;<span class="visualBasic__keyword">Then</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'Chastise&nbsp;the&nbsp;user&nbsp;for&nbsp;not&nbsp;selecting&nbsp;a&nbsp;file&nbsp;:)</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;MsgBox(<span class="visualBasic__string">&quot;Usted&nbsp;no&nbsp;selecciono&nbsp;nig&uacute;n&nbsp;archivo&quot;</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Else</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;txtNombreArchivo.Text&nbsp;=&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.IO.Path.GetFileName.aspx" target="_blank" title="Auto generated link to System.IO.Path.GetFileName">System.IO.Path.GetFileName</a>(strFileNameAndPath)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;txtUbicacion.Text&nbsp;=&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.IO.Path.GetDirectoryName.aspx" target="_blank" title="Auto generated link to System.IO.Path.GetDirectoryName">System.IO.Path.GetDirectoryName</a>(strFileNameAndPath)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;txtExtencionArchivo.Text&nbsp;=&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.IO.Path.GetExtension.aspx" target="_blank" title="Auto generated link to System.IO.Path.GetExtension">System.IO.Path.GetExtension</a>(strFileNameAndPath)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;txtCreadoArchivo.Text&nbsp;=&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.IO.File.GetCreationTime.aspx" target="_blank" title="Auto generated link to System.IO.File.GetCreationTime">System.IO.File.GetCreationTime</a>(strFileNameAndPath)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;txtModificoArchivo.Text&nbsp;=&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.IO.File.GetLastWriteTime.aspx" target="_blank" title="Auto generated link to System.IO.File.GetLastWriteTime">System.IO.File.GetLastWriteTime</a>(strFileNameAndPath)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'Begin&nbsp;doing&nbsp;whatever&nbsp;it&nbsp;is&nbsp;you&nbsp;would&nbsp;normally&nbsp;do&nbsp;with&nbsp;the&nbsp;file!</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'MsgBox(&quot;You&nbsp;selected&nbsp;this&nbsp;file:&nbsp;&quot;&nbsp;&amp;&nbsp;strFileNameAndPath&nbsp;&amp;&nbsp;vbCrLf&nbsp;&amp;&nbsp;_</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'&nbsp;&nbsp;&nbsp;&quot;The&nbsp;filename&nbsp;is:&nbsp;&quot;&nbsp;&amp;&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.IO.Path.GetFileName.aspx" target="_blank" title="Auto generated link to System.IO.Path.GetFileName">System.IO.Path.GetFileName</a>(strFileNameAndPath)&nbsp;&amp;&nbsp;vbCrLf&nbsp;&amp;&nbsp;_</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'&nbsp;&nbsp;&nbsp;&quot;Located&nbsp;in:&nbsp;&quot;&nbsp;&amp;&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.IO.Path.GetDirectoryName.aspx" target="_blank" title="Auto generated link to System.IO.Path.GetDirectoryName">System.IO.Path.GetDirectoryName</a>(strFileNameAndPath)&nbsp;&amp;&nbsp;vbCrLf&nbsp;&amp;&nbsp;_</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'&nbsp;&nbsp;&nbsp;&quot;It&nbsp;has&nbsp;the&nbsp;following&nbsp;extension:&nbsp;&quot;&nbsp;&amp;&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.IO.Path.GetExtension.aspx" target="_blank" title="Auto generated link to System.IO.Path.GetExtension">System.IO.Path.GetExtension</a>(strFileNameAndPath)&nbsp;&amp;&nbsp;vbCrLf&nbsp;&amp;&nbsp;_</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'&nbsp;&nbsp;&nbsp;&quot;The&nbsp;file&nbsp;was&nbsp;created&nbsp;on&nbsp;&quot;&nbsp;&amp;&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.IO.File.GetCreationTime.aspx" target="_blank" title="Auto generated link to System.IO.File.GetCreationTime">System.IO.File.GetCreationTime</a>(strFileNameAndPath)&nbsp;&amp;&nbsp;vbCrLf&nbsp;&amp;&nbsp;_</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">'&nbsp;&nbsp;&nbsp;&quot;The&nbsp;file&nbsp;was&nbsp;last&nbsp;written&nbsp;to&nbsp;on&nbsp;&quot;&nbsp;&amp;&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.IO.File.GetLastWriteTime.aspx" target="_blank" title="Auto generated link to System.IO.File.GetLastWriteTime">System.IO.File.GetLastWriteTime</a>(strFileNameAndPath)&nbsp;_</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__com">')</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">If</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Private</span>&nbsp;<span class="visualBasic__keyword">Function</span>&nbsp;QuitarAdjunto(<span class="visualBasic__keyword">ByVal</span>&nbsp;Quitar&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">String</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;fileDialogBox&nbsp;=&nbsp;<span class="visualBasic__keyword">New</span>&nbsp;OpenFileDialog&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;txtNombreArchivo.Text&nbsp;=&nbsp;Quitar&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;txtExtencionArchivo.Text&nbsp;=&nbsp;Quitar&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;txtCreadoArchivo.Text&nbsp;=&nbsp;Quitar&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;txtModificoArchivo.Text&nbsp;=&nbsp;Quitar&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;txtUbicacion.Text&nbsp;=&nbsp;Quitar&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Return</span>&nbsp;<span class="visualBasic__keyword">False</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Function</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Private</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;btnQuitarAdjunto_Click(sender&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">Object</span>,&nbsp;e&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;EventArgs)&nbsp;<span class="visualBasic__keyword">Handles</span>&nbsp;btnQuitarAdjunto.Click&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Cursor&nbsp;=&nbsp;Cursors.AppStarting&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;QuitarAdjunto(<span class="visualBasic__string">&quot;&quot;</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Cursor&nbsp;=&nbsp;Cursors.Arrow&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Private</span>&nbsp;<span class="visualBasic__keyword">Function</span>&nbsp;VaciarCorreo(<span class="visualBasic__keyword">ByVal</span>&nbsp;vaciar&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">String</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;txtNombre.Text&nbsp;=&nbsp;<span class="visualBasic__string">&quot;&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;txtCorreo.Text&nbsp;=&nbsp;<span class="visualBasic__string">&quot;&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;txtContrase&ntilde;a.Text&nbsp;=&nbsp;<span class="visualBasic__string">&quot;&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;txtPara.Text&nbsp;=&nbsp;<span class="visualBasic__string">&quot;&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;txtCC.Text&nbsp;=&nbsp;<span class="visualBasic__string">&quot;&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;txtAsunto.Text&nbsp;=&nbsp;<span class="visualBasic__string">&quot;&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;txtMensaje.Text&nbsp;=&nbsp;<span class="visualBasic__string">&quot;&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;QuitarAdjunto(<span class="visualBasic__string">&quot;&quot;</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Return</span>&nbsp;<span class="visualBasic__keyword">False</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Function</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Private</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;btnEnviarCorreo_Click(sender&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">Object</span>,&nbsp;e&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;EventArgs)&nbsp;<span class="visualBasic__keyword">Handles</span>&nbsp;btnEnviarCorreo.Click&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Cursor&nbsp;=&nbsp;Cursors.AppStarting&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">If</span>&nbsp;txtCorreo.Text&nbsp;=&nbsp;<span class="visualBasic__string">&quot;&quot;</span>&nbsp;<span class="visualBasic__keyword">Or</span>&nbsp;txtContrase&ntilde;a.Text&nbsp;=&nbsp;<span class="visualBasic__string">&quot;&quot;</span>&nbsp;<span class="visualBasic__keyword">Or</span>&nbsp;txtPara.Text&nbsp;=&nbsp;<span class="visualBasic__string">&quot;&quot;</span>&nbsp;<span class="visualBasic__keyword">Then</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show(<span class="visualBasic__string">&quot;No&nbsp;puede&nbsp;enviar&nbsp;el&nbsp;correo,&nbsp;verifique&nbsp;los&nbsp;datos&nbsp;ingresados&quot;</span>,&nbsp;<span class="visualBasic__string">&quot;Acceso&nbsp;denegado&quot;</span>,&nbsp;MessageBoxButtons.OK,&nbsp;MessageBoxIcon.<span class="visualBasic__keyword">Error</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Else</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">If</span>&nbsp;txtUbicacion.Text&nbsp;=&nbsp;<span class="visualBasic__string">&quot;&quot;</span>&nbsp;<span class="visualBasic__keyword">Then</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">If</span>&nbsp;txtCC.Text&nbsp;=&nbsp;<span class="visualBasic__string">&quot;&quot;</span>&nbsp;<span class="visualBasic__keyword">Then</span>&nbsp;Enviar_Correo_SinCC()&nbsp;<span class="visualBasic__keyword">Else</span>&nbsp;Enviar_Correo()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Else</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">If</span>&nbsp;txtCC.Text&nbsp;=&nbsp;<span class="visualBasic__string">&quot;&quot;</span>&nbsp;<span class="visualBasic__keyword">Then</span>&nbsp;Enviar_Correo_SinCC()&nbsp;<span class="visualBasic__keyword">Else</span>&nbsp;Enviar_Correo_Adjunto()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">If</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;VaciarCorreo(<span class="visualBasic__string">&quot;&quot;</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">If</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Cursor&nbsp;=&nbsp;Cursors.Arrow&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Private</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;CerrarToolStripMenuItem_Click(sender&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">Object</span>,&nbsp;e&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;EventArgs)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Close()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Private</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;NotifyIcon1_MouseDoubleClick(sender&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">Object</span>,&nbsp;e&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;MouseEventArgs)&nbsp;<span class="visualBasic__keyword">Handles</span>&nbsp;NotifyIcon1.MouseDoubleClick&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Process.Start(<span class="visualBasic__string">&quot;www.JandC-ec.webs.com&quot;</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Private</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;EnviarCorreoToolStripMenuItem_Click(sender&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">Object</span>,&nbsp;e&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;EventArgs)&nbsp;<span class="visualBasic__keyword">Handles</span>&nbsp;EnviarCorreoToolStripMenuItem.Click&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Cursor&nbsp;=&nbsp;Cursors.AppStarting&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Dim</span>&nbsp;res&nbsp;=&nbsp;DialogResult&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;res&nbsp;=&nbsp;MessageBox.Show(<span class="visualBasic__string">&quot;&iquest;Desea&nbsp;enviar&nbsp;el&nbsp;correo?&quot;</span>,&nbsp;<span class="visualBasic__string">&quot;Enviar&nbsp;Correo&quot;</span>,&nbsp;MessageBoxButtons.YesNo,&nbsp;MessageBoxIcon.Question)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">If</span>&nbsp;res&nbsp;=&nbsp;Windows.Forms.DialogResult.Yes&nbsp;<span class="visualBasic__keyword">Then</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;btnEnviarCorreo_Click(btnEnviarCorreo,&nbsp;e)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Else</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">If</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Cursor&nbsp;=&nbsp;Cursors.Arrow&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Private</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;NuevoCorreoToolStripMenuItem_Click(sender&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">Object</span>,&nbsp;e&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;EventArgs)&nbsp;<span class="visualBasic__keyword">Handles</span>&nbsp;NuevoCorreoToolStripMenuItem.Click&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Cursor&nbsp;=&nbsp;Cursors.AppStarting&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Dim</span>&nbsp;res&nbsp;=&nbsp;DialogResult&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;res&nbsp;=&nbsp;MessageBox.Show(<span class="visualBasic__string">&quot;&iquest;Desea&nbsp;crear&nbsp;un&nbsp;nuevo&nbsp;correo?&quot;</span>,&nbsp;<span class="visualBasic__string">&quot;Nuevo&nbsp;Correo&quot;</span>,&nbsp;MessageBoxButtons.YesNo,&nbsp;MessageBoxIcon.Question)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">If</span>&nbsp;res&nbsp;=&nbsp;Windows.Forms.DialogResult.Yes&nbsp;<span class="visualBasic__keyword">Then</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;VaciarCorreo(<span class="visualBasic__string">&quot;&quot;</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Else</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">If</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Cursor&nbsp;=&nbsp;Cursors.Arrow&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Private</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;VisitarPaginaWebToolStripMenuItem_Click(sender&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">Object</span>,&nbsp;e&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;EventArgs)&nbsp;<span class="visualBasic__keyword">Handles</span>&nbsp;VisitarPaginaWebToolStripMenuItem.Click&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show(<span class="visualBasic__string">&quot;Gracias&nbsp;por&nbsp;apoyar&nbsp;nuesro&nbsp;trabajo&quot;</span>,&nbsp;<span class="visualBasic__string">&quot;Muchas&nbsp;gracias&nbsp;Atte.&nbsp;Josu&eacute;&nbsp;Chavez&quot;</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Process.Start(<span class="visualBasic__string">&quot;www.JandC-ec.webs.com&quot;</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Private</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;LikeEnFacebookToolStripMenuItem_Click(sender&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">Object</span>,&nbsp;e&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;EventArgs)&nbsp;<span class="visualBasic__keyword">Handles</span>&nbsp;LikeEnFacebookToolStripMenuItem.Click&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show(<span class="visualBasic__string">&quot;Gracias&nbsp;por&nbsp;apoyar&nbsp;nuesro&nbsp;trabajo&quot;</span>,&nbsp;<span class="visualBasic__string">&quot;Muchas&nbsp;gracias&nbsp;Atte.&nbsp;Josu&eacute;&nbsp;Chavez&quot;</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Process.Start(<span class="visualBasic__string">&quot;www.facebook.com/JandC.Ecuador&quot;</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Private</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;S&iacute;guenosEnTwitterToolStripMenuItem_Click(sender&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">Object</span>,&nbsp;e&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;EventArgs)&nbsp;<span class="visualBasic__keyword">Handles</span>&nbsp;S&iacute;guenosEnTwitterToolStripMenuItem.Click&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show(<span class="visualBasic__string">&quot;Gracias&nbsp;por&nbsp;apoyar&nbsp;nuesro&nbsp;trabajo&quot;</span>,&nbsp;<span class="visualBasic__string">&quot;Muchas&nbsp;gracias&nbsp;Atte.&nbsp;Josu&eacute;&nbsp;Chavez&quot;</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Process.Start(<span class="visualBasic__string">&quot;www.twitter.com/JandC_Ecuador&quot;</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Private</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;SalirToolStripMenuItem_Click(sender&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">Object</span>,&nbsp;e&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;EventArgs)&nbsp;<span class="visualBasic__keyword">Handles</span>&nbsp;SalirToolStripMenuItem.Click&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Close()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">Private</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;FormEnviarCorreo_FormClosed(sender&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;<span class="visualBasic__keyword">Object</span>,&nbsp;e&nbsp;<span class="visualBasic__keyword">As</span>&nbsp;FormClosedEventArgs)&nbsp;<span class="visualBasic__keyword">Handles</span>&nbsp;<span class="visualBasic__keyword">MyBase</span>.FormClosed&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;NotifyIcon1.Visible&nbsp;=&nbsp;<span class="visualBasic__keyword">False</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Sub</span>&nbsp;
<span class="visualBasic__keyword">End</span>&nbsp;<span class="visualBasic__keyword">Class</span></pre>
</div>
</div>
</div>
<h1>Al finalizar quedara asi nuestro ejemplo</h1>
<p>-puedes descargar este ejemplo</p>
<p><img id="109121" src="109121-enviarcorreo3.png" alt=""></p>
<h1><span>Codigos</span></h1>
<ul>
<li><em>import <a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.net.aspx" target="_blank" title="Auto generated link to System.net">System.net</a></em> </li><li><em>imports <a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/system.net.mail.aspx" target="_blank" title="Auto generated link to system.net.mail">system.net.mail</a></em> </li></ul>
<h1>Mayor informaci&oacute;n.</h1>
<p><em>para mayor informaci&oacute;n visita nuestra pag&iacute;na web</em></p>
<p><em>http://www.jandc-ec.webs.com</em></p>
<p><em>http://www.facebook.com/JandC.Ecuador</em></p>
<p><em>http://www.twitter.com/JandC_Ecuador</em></p>
<p><em><br>
</em></p>
