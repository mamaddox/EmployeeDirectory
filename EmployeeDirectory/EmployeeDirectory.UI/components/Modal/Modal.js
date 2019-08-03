class Modal extends React.Component {
	render() {
		return (
			<div className="modal fade" id={this.props.modalId} tabIndex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
				<div className="modal-dialog modal-dialog-centered" role="document">
					<div className="modal-content">
						<div className="modal-header">
							<button type="button" className="close" data-dismiss="modal" aria-label="Close">
								<span aria-hidden="true">&times;</span>
							</button>
						</div>
						<div className="modal-body">
							<form>
								{this.props.attributes.PictureFields.map((field, i) => {
									return (
										<div className="form-group" key={i}>
											<img src={this.props.modalObj[field]} />
										</div>
									);
								})}
								{this.props.attributes.Fields.filter(field => !this.props.attributes.PictureFields.includes(field)).map((key, i) => {
									return (
										<div className="form-group" key={i}>
											<label className="col-form-label">{key}</label>
											<span type="text" className="form-control" id="recipient-name">{this.props.modalObj[key]}</span>
										</div>
									);
								})}
							</form>
						</div>
						<div className="modal-footer">
							<button type="button" className="btn btn-secondary" data-dismiss="modal">Close</button>
						</div>
					</div>
				</div>
			</div>
		);
	}
}