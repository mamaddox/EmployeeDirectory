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
					{this.props.rows.map((row, i) => {
						return (
							<Row 
								key={i}
								rowObj={row}/>
							);
						}
					)}
				</tbody>
			</table>
		);
	}
}