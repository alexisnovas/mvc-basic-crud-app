@ModelType MvcBasicCrud.Empleado
@Code
    ViewData("Title") = "DeleteConfirmed"
End Code

<h2>DeleteConfirmed</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Empleado</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Edad)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Edad)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Salario)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Salario)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
