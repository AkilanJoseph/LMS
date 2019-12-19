var baseApiUrl = "https://localhost:44343/api/";

$(function () {
    GetBookGrid(null);
});

$(document).ready(function () {
    $(document).off("click", "#btnSearch").on("click", "#btnSearch", function () {
        GetBookGrid($.trim($("#txtSearch").val()));
    });

    $(document).off("click", "#btnClear").on("click", "#btnClear", function () {
        $('#txtSearch').val('');
        GetBookGrid(null);
    });

    $(document).off("click", "#btnSubmit").on("click", "#btnSubmit", function () {
        var inputData = {};
        inputData["BookName"] = $('#txtBookName').val();
        inputData["AuthorName"] = $('#txtAuthorName').val();
        inputData["Category"] = $('#txtBookCategory').val();
        inputData["Edition"] = $('#txtEdition').val();
        inputData["Price"] = $('#txtPrice').val();
        inputData["Publisher"] = $('#txtPublisher').val();
        
        $.ajax({
            url: baseApiUrl + "library/",
            type: "POST",
            contentType: 'application/json',
            data: JSON.stringify(inputData),
            success: function (data) {
                $('#txtBookName').val('');
                $('#txtAuthorName').val('');
                $('#txtBookCategory').val('');
                $('#txtEdition').val('');
                $('#txtPrice').val('');
                $('#txtPublisher').val('');
                alert(data);
            }
        });
    });
});

function GetBookGrid(searchData) {
    $.ajax({
        url: (searchData == null) ? baseApiUrl + "library/" : baseApiUrl + "library/" + searchData + "/search",
        type: "GET",
        contentType: 'application/json',
        success: function (data) {
            if (data != null) {
                var trVal = '';
                $.each(data, function () {
                    trVal += "<tr><td>" +
                        $(this)[0].bookName + "</td><td>" +
                        $(this)[0].authorName + "</td><td>" +
                        $(this)[0].category + "</td><td>" +
                        $(this)[0].edition + "</td><td>" +
                        $(this)[0].price + "</td><td>" +
                        $(this)[0].publisher + "</td></tr>";
                });
                $('#tblBookDetail tbody').html('');
                $('#tblBookDetail tbody').html(trVal);
            }
            else {
                $('#tblBookDetail tbody').html('');
                alert("No record found.");
            }
        }
    });
}