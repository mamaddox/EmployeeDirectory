class RowsPerPageDropdown extends React.Component {
	onChange = (event) => {
		this.props.updateRowCount(event.target.value);
	}

	render() {
		return (
			<nav aria-label="...">
			    <ul className="pagination">
				    <li className="page-item disabled">
				      <span className="page-link">Show</span>
				    </li>
				    <li className="page-item">
						<select className="btn btn-outline-secondary" 
							style={{height: "38px"}} 
							onChange={this.onChange}
							defaultValue={EmployeeDirectoryConstants.DefaultRowCount}>
					    	{EmployeeDirectoryConstants.RowsPerPageOptions.map((option, i) => {
					    		return (<option key={i}>{option}</option>);
					    	})}
						</select>
			    	</li>
				    <li className="page-item disabled">
				    	<a className="page-link" href="#">Results</a>
				    </li>
			    </ul>
		    </nav>
		);
	}
}
