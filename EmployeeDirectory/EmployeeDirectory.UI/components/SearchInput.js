class SearchInput extends React.Component {
	render() {
		return (
			<div className="input-group" style={{marginBottom: "25px"}}>
				<div className="input-group-prepend">
					<select className="btn btn-outline-secondary">
						<option value=""> </option>
						{this.props.fields.map((field, i) => {
							return <option key={i}>{field}</option>
						})}
					</select>
				</div>
				<input type="text" className="form-control" placeholder="Enter Search Criteria..." />
				<div className="input-group-append">
				  <button className="btn btn-outline-secondary" type="button">Search</button>
				</div>
			</div>
		);
	}
}