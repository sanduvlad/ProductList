var intervalID = window.setInterval(UpdateProducts, 5000);

function UpdateProducts() {
    $.get("http://localhost:53714/Shoplist/ProductList", function (data) {
        $("#FruitList").html(data);

    });
}

function OnLoadEvent() {
    UpdateProducts();
}

function AddNewProductClickEvent()
{
    var element = document.getElementById("AddNewProdButton");
    element.setAttribute("style", "visibility:hidden");
    console.log("adas");
}