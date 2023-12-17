// Script for simple search in CRUDs
$(document).ready(function () {
	$("#searchInput").on("keyup", function () {
		var value = $(this).val().toLowerCase();
		$("#resultTable tr").filter(function () {
			$(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
		});
	});
});	

