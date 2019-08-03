DirectoryAPI = {};

DirectoryAPI.getEmployees = function(callback) {
	$.ajax({
		url: EmployeeDirectoryConstants.ApiUrl + "api/Employees",
		type: "GET",
		success: function(data) {
			callback(data);
		},
		error: function(err) {
			console.log(err);
		}
	})
};

DirectoryAPI.getBySearchParameters = function(parameters, callback) {
	$.ajax({
		url: EmployeeDirectoryConstants.ApiUrl + "api/Search",
		type: "POST",
		contentType: "application/json; charset=utf-8",
		data: JSON.stringify(parameters),
		success: function(data) {
			callback(data);
		},
		error: function(err) {
			console.log(err);
		}
	})
};