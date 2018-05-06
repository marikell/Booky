function saveBook(type) {
    var title = $("#Title").val();
    var author = $("#Author").val();
    var bookPublisher = $("#BookPublisher").val()
    var description = $("#Description").val()
    var qtyStock = $("#StockQty").val()
    var price = $("#Price").val()

    var obj = {
        Title: title,
        Author: author,
        BookPublisher: bookPublisher,
        Title: title,
        Description: description,
        StockQty: qtyStock,
        Price: price,
        IdBook: 0
    }

    var url = (type === 'Create') ? '/Book/CreateBook' : '/Book/EditBook';

    if (type === "Edit") {
        obj.IdBook = $("#IdBook").val()
    }

    $.ajax({
        type: "post",
        url: url,
        data: obj,
        success: function () {
            window.location.href = '/Book/Index'
        }
    });
}

function editBook(button) {
    var id = $(button).attr("id");
    id = id.slice(8);

    window.location.href = '/Book/Edit?id=' + id;
    

   
}

function deleteBook(button) {
    var id = $(button).attr("id");
    id = id.slice(10);

    $.ajax({
        type: "post",
        url: "/Book/Delete?id=" +id,
        data: { id: id },
        success: function () {
            $('#' + id).remove();
        }
    });

}

function search() {
    var filter = $("#dplSearch").select()
    var text = $("#txtSearch").val()

    $.ajax({
        type: "post",
        url: "/Book/Search",
        data: { filter:filter, text:text },
        success: function () {


        }
    });

}