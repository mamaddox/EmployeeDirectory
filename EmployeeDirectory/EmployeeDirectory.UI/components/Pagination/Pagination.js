class Pagination extends React.Component {
	setNextPage = () => {
		if (this.props.currentPage !== this.props.maxPage)
			this.props.updateCurrentPage(this.props.currentPage + 1);
	}

	setPreviousPage = () => {
		if (this.props.currentPage !== 1)
			this.props.updateCurrentPage(this.props.currentPage - 1);
	}

	getPageNumbers = () => {
		let pageNumbers = [];
		for(var i = 1; i <= this.props.maxPage; i++) {
			pageNumbers.push(i);
		};
		return pageNumbers;
	}

	render() {
		return (
			<nav aria-label="...">
				<ul className="pagination justify-content-end">
					<li className={"page-item " + (this.props.currentPage === 1 ? "disabled" : "")} onClick={this.setPreviousPage}>
						<span className="page-link">Previous</span>
					</li>
					{this.getPageNumbers().map((page, i) => {
						return (<li className={"page-item " + (page === this.props.currentPage ? "active" : "")} key={i}>
								<a className="page-link" href="#">{page}</a>
							</li>);
					})}
					<li className={"page-item " + (this.props.maxPage === 1 ? "disabled" : "")} onClick={this.setNextPage}>
					  <a className="page-link" href="#">Next</a>
					</li>
				</ul>
			</nav>
		);
	}
}
