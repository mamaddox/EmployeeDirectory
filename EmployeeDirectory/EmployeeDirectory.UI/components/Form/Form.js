class Form extends React.Component {
    render() {
    	return(
			<form>
				{this.props.attributes.PictureFields.map((field, i) => {
					return (
						<div className="form-group" key={i}>
							<img src={this.props.formValues[field]} />
						</div>
					);
				})}
				{this.props.attributes.Fields.filter(field => !this.props.attributes.PictureFields.includes(field)).map((key, i) => {
					return (
						<div className="form-group" key={i}>
							<label className="col-form-label">{key}</label>
							<span type="text" className="form-control" id="recipient-name">{this.props.formValues[key]}</span>
						</div>
					);
				})}
			</form>
		);
    }
}