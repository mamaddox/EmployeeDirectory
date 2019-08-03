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
					fields={this.props.attributes.Fields}/>
				{this.state.rows.length !== 0 &&
					<Table 
						attributes={this.props.attributes}
						rows={this.state.rows} />
				}
				<Pagination />
			</div>
		);
	}
}