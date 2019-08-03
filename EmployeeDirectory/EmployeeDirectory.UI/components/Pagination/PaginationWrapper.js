class PaginationWrapper extends React.Component {
	render() {
		return (
			<div className="container">
				<div className="row">
					<div className="col-sm">
						<RowsPerPageDropdown
							rowCount={this.props.rowCount}
							updateRowCount={this.props.updateRowCount}/>
				    </div>
				    <div className="col-sm">
						<Pagination 
							currentPage={this.props.currentPage}
							maxPage={this.props.maxPage}
							rowCount={this.props.rowCount}
							numberOfRows={this.props.numberOfRows}
							updateCurrentPage={this.props.updateCurrentPage}/>
					</div>
				</div>
			</div>
		);
	}
}