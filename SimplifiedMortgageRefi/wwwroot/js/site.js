// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function addCommas(nStr) {
	nStr += '';
	x = nStr.split('.');
	x1 = x[0];
	x2 = x.length > 1 ? '.' + x[1] : '';
	var rgx = /(\d+)(\d{3})/;
	while (rgx.test(x1)) {
		x1 = x1.replace(rgx, '$1' + ',' + '$2');
	}
	return x1 + x2;
}

$(document).ready(function () {
	$('#myTable').DataTable();
});

$('.multiple-items').slick({
	arrows: true,
	infinite: true,
	slidesToShow: 2,
	slidesToScroll: 1
});


$("#editCurrentMortgage").click(function () {
    $.get('@Url.Action("EditCurrentMortgage","Customers")', {}, function (response) {
        $("#Display").html(response);
    });
});