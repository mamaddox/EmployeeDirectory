class Row extends React.Component {
	render() {
		const row = this.props.rowObj;
		return (
			<tr>
				{Object.keys(row).map((key, i) => {
					return (
						<Cell 
							key={i}
							value={row[key]}/>
						);
				})}
		    </tr>
		);
	}
}