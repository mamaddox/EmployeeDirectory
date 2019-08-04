class SearchForm extends React.Component {
	constructor(props) {
		super(props);
		this.state = {
			rows: [],
			visibleRows: [],
			rowCount: this.props.constants.DefaultRowCount,
			currentPage: 1,
			numberOfRows: 0
		};
	}

	componentDidMount() {
		this.getRows();
	}

	getRows = () => {
		this.props.getData(this.setRows);
	}

	setRows = rows => {
		this.setState({rows: rows, numberOfRows: rows.length}, this.updateVisibleRows);
	}

	updateVisibleRows = () => {
		const currentPage = this.state.currentPage;
		const rowCount = this.state.rowCount;
		const rows = this.state.rows;
		let visibleRows = rows.slice(currentPage * rowCount - rowCount, currentPage * rowCount + 1);
		this.setState({visibleRows: visibleRows});
	}

	updateRowCount = rowCount => {
		this.setState({rowCount: rowCount}, this.updateVisibleRows);
	}

	updateCurrentPage = page => {
		this.setState({currentPage: page}, this.updateVisibleRows);
	}

	handleSearch = searchParameters => {
		this.props.handleSearch(searchParameters, this.setRows);
	}

	render() {
		return(
			<div>
				<SearchInput 
					attributes={this.props.attributes}
					handleSearch={this.handleSearch} />
				{this.state.numberOfRows !== 0 &&
					<Table 
						attributes={this.props.attributes}
						rows={this.state.visibleRows} />
				}
				<PaginationWrapper
                    constants={this.props.constants}
					rowCount={this.state.rowCount}
					currentPage={this.state.currentPage}
					maxPage={Math.ceil(this.state.numberOfRows / this.state.rowCount)}
					updateRowCount={this.updateRowCount}
					updateCurrentPage={this.updateCurrentPage} />
			</div>
		);
	}
}