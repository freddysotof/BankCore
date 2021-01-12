﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoreBll;

namespace BanCore.Services
{
    public class ClientService
    {
        private static CoreDbEntities db = new CoreDbEntities();
        public string Insert(Client client)
        {
            if (ValidationHandler.ValidateClient(client))
            {
                try
                {
                    db.Database.BeginTransaction();
                    db.InsertOrUpdateClient(client.Id, client.Name, client.LastName, client.IdentificationTypeId, 
                        client.Identification, client.Telephone, client.Address,client.GenderId,(int)Status.Active,null
                    );
                    db.Database.CurrentTransaction.Commit();
                    return "Cliente Creado";
                }
                catch (Exception e)
                {
                    db.Database.CurrentTransaction.Rollback();
                }
            }
            return "El cliente no puede ser registrado, favor verifique los campos requeridos";
        }
        public string Update(Client client)
        {
            if (ValidationHandler.ValidateClient(client))
            {
                try
                {
                    db.Database.BeginTransaction();
                    db.InsertOrUpdateClient(client.Id, client.Name, client.LastName, client.IdentificationTypeId,
                        client.Identification, client.Telephone, client.Address, client.GenderId, client.StatusId, null
                    );
                    db.Database.CurrentTransaction.Commit();
                    return "Cliente Modificado";
                }
                catch (Exception e)
                {
                    db.Database.CurrentTransaction.Rollback();
                }
            }
            return "El cliente no puede ser modificado, favor verifique los campos requeridos";
        }
        public string Delete(int id)
        {
            var Client = GetById(id);
            if (Client.Id == 0)
                return "Este cliente no existe";
            Client.Status = Status.Inactive;
            Update(Client);

            return "Cliente desactivado.";
        }
        public List<Client> GetAll()
        {
            List<Client> clients = new List<Client>();
            var rows = db.getclients(null, null);
            if (rows.Count() > 0)
            {
                foreach (var r in rows)
                {
                    clients.Add(new Client
                    {
                        Address = r.Address,
                        CurrencyType = (CurrencyType)r.CurrencyTypeId,
                        Gender = (Gender)r.GenderId,
                        Id = (int)r.Id,
                        Identification = r.Identification,
                        IdentificationType = (IdentificationType)r.IdentificationTypeId,
                        LastName = r.LastName,
                        Name = r.Name,
                        Status = (Status)r.StatusId,
                        Telephone = r.Telephone
                    });
                }
            }
            return clients;
        }
        public Client GetById(int id)
        {
            Client client = new Client();
            var rows = db.getclients(id, null);
            if (rows.Count() == 1)
            {
                var r = rows.FirstOrDefault();
                client = new Client
                {
                    Address = r.Address,
                    CurrencyType = (CurrencyType)r.CurrencyTypeId,
                    Gender = (Gender)r.GenderId,
                    Id = (int)r.Id,
                    Identification = r.Identification,
                    IdentificationType = (IdentificationType)r.IdentificationTypeId,
                    LastName = r.LastName,
                    Name = r.Name,
                    Status = (Status)r.StatusId,
                    Telephone = r.Telephone
                };
            }
            return client;
        }
        public Client GetByIdentification(string identification)
        {
            Client client = new Client();
            var rows = db.getclients(null, identification);
            if (rows.Count() == 1)
            {
                var r = rows.FirstOrDefault();
                client = new Client
                {
                    Address = r.Address,
                    CurrencyType = (CurrencyType)r.CurrencyTypeId,
                    Gender = (Gender)r.GenderId,
                    Id = (int)r.Id,
                    Identification = r.Identification,
                    IdentificationType = (IdentificationType)r.IdentificationTypeId,
                    LastName = r.LastName,
                    Name = r.Name,
                    Status = (Status)r.StatusId,
                    Telephone = r.Telephone
                };
            }
            return client;
        }
    }
}