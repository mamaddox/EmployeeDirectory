class SearchForm extends React.Component {
	render() {
		console.log(this.props.fields);
		return(
			<div>
				<SearchInput 
					fields={this.props.fields}/>
				<Table 
					fields={this.props.fields}/>
				<Pagination />
			</div>
		);
	}
}