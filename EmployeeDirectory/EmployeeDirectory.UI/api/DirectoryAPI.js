DirectoryAPI = {};

DirectoryAPI.getEmployees = function(callback) {
	$.ajax({
		url: EmployeeDirectoryConstants.ApiUrl + "api/Employees",
		type: "GET",
		datatype : "application/json",
		success: function(data) {
			callback(data);
		},
		error: function(err) {
			console.log(err);
		}
	})
};