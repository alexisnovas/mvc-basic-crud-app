﻿@ModelType MvcBasicCrud.Empleado
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
