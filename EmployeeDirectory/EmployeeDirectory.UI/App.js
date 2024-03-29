﻿class App extends React.Component {
	constructor() {
		super();
		this.state = {
			attributes: {}
		};
	}

	componentDidMount() {
		this.getAttributes();
	}

	getAttributes = () => {
		EmployeeAPI.getAttributes(this.setAttributes);
	}

	setAttributes = attributes => {
		this.setState({attributes: attributes})
	}

    render() {
        return(
			<div className="jumbotron bg-white d-flex align-items-center">
				<div className="container text-center">
					<h1>Employee Directory</h1>
					{Object.keys(this.state.attributes).length !== 0 && 
                        <SearchForm
                            constants={EmployeeDirectoryConstants}
							attributes={this.state.attributes} 
		        			getData={DirectoryAPI.getEmployees}
		        			handleSearch={DirectoryAPI.getBySearchParameters}/>
	        		}
				</div>
			</div>
    	);
    }
}