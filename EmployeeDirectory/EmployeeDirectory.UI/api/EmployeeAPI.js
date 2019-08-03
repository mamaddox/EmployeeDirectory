EmployeeAPI = {};

EmployeeAPI.getFields = function(callback) {
	$.ajax({
		url: EmployeeDirectoryConstants.ApiUrl + "api/Fields",
		type: "GET",
		success: function(data) {
			callback(data);
		},
		error: function(err) {
			console.log(err);
		}
	})
};
