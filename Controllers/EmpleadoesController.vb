Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports MvcBasicCrud

Namespace Controllers
    Public Class EmpleadoesController
        Inherits System.Web.Mvc.Controller

        Private db As New TestEntities1

        ' GET: Empleadoes
        Function Index() As ActionResult
            Return View(db.Empleado.ToList())
        End Function

        ' GET: Empleadoes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empleado As Empleado = db.Empleado.Find(id)
            If IsNothing(empleado) Then
                Return HttpNotFound()
            End If
            Return View(empleado)
        End Function

        ' GET: Empleadoes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Empleadoes/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,Nombre,Edad,Salario")> ByVal empleado As Empleado) As ActionResult
            If ModelState.IsValid Then
                db.Empleado.Add(empleado)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(empleado)
        End Function

        ' GET: Empleadoes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empleado As Empleado = db.Empleado.Find(id)
            If IsNothing(empleado) Then
                Return HttpNotFound()
            End If
            Return View(empleado)
        End Function

        ' POST: Empleadoes/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,Nombre,Edad,Salario")> ByVal empleado As Empleado) As ActionResult
            If ModelState.IsValid Then
                db.Entry(empleado).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(empleado)
        End Function

        ' GET: Empleadoes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empleado As Empleado = db.Empleado.Find(id)
            If IsNothing(empleado) Then
                Return HttpNotFound()
            End If
            Return View(empleado)
        End Function

        ' POST: Empleadoes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim empleado As Empleado = db.Empleado.Find(id)
            db.Empleado.Remove(empleado)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
