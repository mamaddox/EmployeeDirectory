class SearchForm extends React.Component {
	constructor() {
		super();
		this.state = {
			rows: []
		};
	}

	componentDidMount() {
		this.getRows();
	}

	getRows = () => {
		this.props.getData(this.setRows);
	}

	setRows = rows => {
		this.setState({rows: rows});
	}

	render() {
		return(
			<div>
				<SearchInput 
					fields={this.props.fields}/>
				{this.state.rows.length !== 0 &&
					<Table 
						fields={this.props.fields}
						rows={this.state.rows} />
				}
				<Pagination />
			</div>
		);
	}
}