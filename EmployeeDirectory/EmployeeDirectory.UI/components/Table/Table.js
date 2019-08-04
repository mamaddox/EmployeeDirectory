class Table extends React.Component {
	constructor() {
		super();
		this.state = {
			rowModalObj: {}
		}
	}
    getVisibleFields = () => {
        const attributes = this.props.attributes;
        return attributes.Fields.filter(field => 
            !attributes.HiddenFields.includes(field)
        );
	}

	onRowClick = rowModalObj => {
		this.setState({rowModalObj: rowModalObj}, () => {$("#RowModal").modal('show')});
	}

	render() {
		return (
			<React.Fragment>
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
								rowId={i}
								rowObj={row}
								visibleFields={this.getVisibleFields()}
								onRowClick={this.onRowClick}/>
							);
						}
					)}
				</tbody>
			</table>
		    <Modal
		    	attributes={this.props.attributes}
		    	modalId={"RowModal"}
		    	modalObj={this.state.rowModalObj} />
			</React.Fragment>
		);
	}
}