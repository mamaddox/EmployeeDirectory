class Table extends React.Component {
	getVisibleFields = () => {
		return this.props.attributes.Fields.filter(field => !this.props.attributes.HiddenFields.includes(field));
	}

	render() {
		return (
			<table className="table table-bordered table-striped">
				<thead>
					<tr>
						{this.getVisibleFields().map((field, i) => {
							return <th key={i}>{field}</th>
						})}
					</tr>
				</thead>
				<tbody>
					{this.props.rows.map((row, i) => {
						return (
							<Row 
								key={i}
								rowObj={row}
								visibleFields={this.getVisibleFields()}/>
							);
						}
					)}
				</tbody>
			</table>
		);
	}
}