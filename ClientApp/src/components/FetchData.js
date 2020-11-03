import React, { Component } from 'react';

export class FetchData extends Component {
    static displayName = FetchData.name;
    static urlBase = "https://storage.googleapis.com/zadatak_bucket/";

  constructor(props) {
      super(props);
      this.populateUserData = this.populateUserData.bind(this);
      this.handleCheckboxClick = this.handleCheckboxClick.bind(this);
    this.state = { users: [], loading: true };
  }

  componentDidMount() {
    this.populateUserData();
  }

    static renderUsersTable(users, handler) {

    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th className="text-start">Users</th>
            <th className="text-center">Admin</th>
            <th className="text-center">User</th>
            <th className="text-center">Guest</th>
          </tr>
        </thead>
        <tbody>
          {users.map(u =>
              <tr key={u.id}>
                <td className="d-flex">
                    <div>
                        <img src={`${this.urlBase}${u.imageUrl}`} className="rounded-circle" width="50px" height="50px" alt={u.imageUrl}/>
                    </div>
                    <div>
                        <b className="ml-2">{u.fullName}</b>
                        <div className="mt-1 ml-2"><small>{u.email}</small></div>
                    </div>
                  </td>
                  <td className="text-center"><input type="checkbox" value={1} checked={u.roles.includes(1)} id={ "_1_" + u.id } onChange={() => handler(`${u.id}`, 1)} /> {' '}</td>
                  <td className="text-center"><input type="checkbox" value={1} checked={u.roles.includes(2)} id={"_2_" + u.id} onChange={() => handler(`${u.id}`, 2)} /> {' '}</td>
                  <td className="text-center"><input type="checkbox" value={3} checked={u.roles.includes(3)} id={"_3_" + u.id} onChange={() => handler(`${u.id}`, 3)} /> {' '}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
    }
    //onChange={e => this.handleCheckboxClick( u.id, 2) }

  render() {
    let contents = this.state.loading
        ? <p><em>Loading...</em></p>
        : FetchData.renderUsersTable(this.state.users, this.handleCheckboxClick);

    return (
      <div>
        {contents}
      </div>
    );
  }

  async populateUserData() {
    const response = await fetch('api/Employee/All');
    const data = await response.json();

    for (let obj of data) {
        let roles = await fetch('api/EmployeeRole/GetRolesForEmployee/' + obj.id);
        roles = await roles.json();
        obj.roles = roles;
        console.log(obj.id + " Roles: " + roles);
    }

    this.setState({ users: data, loading: false });
  }

    async handleCheckboxClick(employeeId, checkboxNo) {
        const isChecked = document.querySelector("#_" + checkboxNo + "_" + employeeId).checked;

        if (isChecked === true) {
            let addStatus = await (await fetch('api/EmployeeRole/Create/' + employeeId + '/' + checkboxNo, {
                method: 'POST'
            })).json();
            alert("Created" + addStatus)
            console.log(addStatus);
        } else {
            let deleteStatus = await (await fetch('api/EmployeeRole/Delete/' + employeeId + '/' + checkboxNo, {
                method: 'DELETE'
            })).json();
            alert(deleteStatus);
            console.log(deleteStatus);
        }
        this.populateUserData();
    }

    handleclick() {
        console.log('clicked');
    }
}
