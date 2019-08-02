class Table extends React.Component {
	render() {
		return (
			<table className="table table-bordered table-striped">
				<thead>
					<tr>
						{this.props.fields.map((field, i) => {
							return <th key={i}>{field}</th>
						})}
					</tr>
				</thead>
				<tbody>
					{this.props.fields.map((x, i) => {
						return (
							<Row 
								key={i}
								rowValues={this.props.fields}/>
							);
						}
					)}
				</tbody>
			</table>
		);
	}
}