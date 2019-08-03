class Row extends React.Component {
	handleClick = () => {
		this.props.onRowClick(this.props.rowObj);
	}

	render() {
		const row = this.props.rowObj;
		return (
			<tr onClick={this.handleClick}>
				{this.props.visibleFields.map((field, i) => {
					return (
						<Cell 
							key={i}
							value={row[field]}/>
						);
				})}
		    </tr>
		);
	}
}