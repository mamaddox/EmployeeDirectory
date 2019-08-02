class Row extends React.Component {
	render() {
		return (
			<tr>
				{this.props.rowValues.map((value, i) => {
					return (
						<Cell 
							key={i}
							value={value}/>
						);
				})}
		    </tr>
		);
	}
}