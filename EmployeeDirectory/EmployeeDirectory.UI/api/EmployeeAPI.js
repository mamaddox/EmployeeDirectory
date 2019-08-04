const EmployeeAPI = {};

EmployeeAPI.getAttributes = function(callback) {
	$.ajax({
		url: EmployeeDirectoryConstants.ApiUrl + "api/EmployeeAttributes",
		type: "GET",
		success: function(data) {
			callback(data);
		},
		error: function(err) {
			console.log(err);
		}
	})
};