class App extends React.Component {
	constructor() {
		super();
		this.state = {
			fields: []
		};
	}

	componentDidMount() {
		this.getFields();
	}

	getFields = () => {
		EmployeeAPI.getFields(this.setFields);
	}

	setFields = fields => {
		this.setState({fields: fields});
	}

    render() {
        return(
			<div className="jumbotron bg-white d-flex align-items-center">
				<div className="container text-center">
					<h1>Employee Directory</h1>
					{this.state.fields.length !== 0 && 
						<SearchForm 
		        			fields={this.state.fields}
		        			getData={DirectoryAPI.getEmployees} />
	        		}
				</div>
			</div>
    	);
    }
}