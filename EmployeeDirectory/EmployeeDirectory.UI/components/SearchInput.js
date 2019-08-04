class SearchInput extends React.Component {
	constructor() {
		super();
		this.state = {
			searchDropdown: "",
			searchInput: ""
		};
	}

	updateSearchInput = event => {
		this.setState({searchInput: event.target.value});
	}

	updateSearchDropdown = event => {
		this.setState({searchDropdown: event.target.value});
	}

	handleSearch = () => {
		this.props.handleSearch(this.getSearchParameters());
	}

	getSearchParameters = () => {
		return {
			"Field": this.state.searchDropdown,
			"Value": this.state.searchInput
		};
	}

	render() {
        const attributes = this.props.attributes;
		return (
			<div className="input-group" style={{marginBottom: "25px"}}>
				<div className="input-group-prepend">
					<select className="btn btn-outline-secondary"
                            onChange={this.updateSearchDropdown}>
						<option value=""> </option>
						{attributes.Fields.map((field, i) => {
							if (!attributes.PictureFields.includes(field))
								return <option key={i}>{field}</option>
						})}
					</select>
				</div>
				<input type="text" 
                        className="form-control" 
                        placeholder="Enter Search Criteria..." 
                        onChange={this.updateSearchInput}/>
				<div className="input-group-append">
				    <button className="btn btn-outline-secondary" 
                            type="button" 
                            onClick={this.handleSearch}>
                        Search
                    </button>
				</div>
			</div>
		);
	}
}