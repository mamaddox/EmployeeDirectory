class Pagination extends React.Component {
	render() {
		return (
			<div className="container">
				<div className="row">
					<div className="col-sm">
						<nav aria-label="...">
						    <ul className="pagination">
							    <li className="page-item disabled">
							      <span className="page-link">Show</span>
							    </li>
							    <li className="page-item">
									<select className="btn btn-outline-secondary" style={{height: "38px"}}>
										<option>10</option>
									</select>
						    	</li>
							    <li className="page-item disabled">
							    	<a className="page-link" href="#">Results</a>
							    </li>
						    </ul>
					    </nav>
				    </div>
				    <div className="col-sm">
						<nav aria-label="...">
							<ul className="pagination justify-content-end">
								<li className="page-item disabled">
									<span className="page-link">Previous</span>
								</li>
								<li className="page-item">
									<a className="page-link" href="#">1</a>
								</li>
								<li className="page-item active">
									<span className="page-link">
										2
										<span className="sr-only">(current)</span>
								  	</span>
								</li>
								<li className="page-item">
									<a className="page-link" href="#">3</a>
								</li>
								<li className="page-item">
								  <a className="page-link" href="#">Next</a>
								</li>
							</ul>
						</nav>
					</div>
				</div>
			</div>
		);
	}
}