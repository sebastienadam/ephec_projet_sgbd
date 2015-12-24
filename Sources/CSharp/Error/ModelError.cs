using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity.Core;

namespace Error {
  public class ModelError {
    public const int ALREADY_CHOSEN_DISH_TYPE = 50014;
    public const int BOOKING_FOR_FULL_RECEPTION = 50007;
    public const int BOOKING_FOR_INVALID_RECEPTION = 50006;
    public const int BOOKING_FOR_SIMULTANEOUS_RECEPTION = 50009;
    public const int CHOOSING_DISH_FOR_NOT_BOOKED_RECEPTION = 50012;
    public const int CHOSEN_DISH_NOT_IN_MENU = 50011;
    public const int CLOSING_BOOKING_DATE_AFTER_RECEPTION_DATE = 50002;
    public const int DATABASE_NOT_FOUND = 4060;
    public const int DATA_NOT_UP_TO_DATE = 50000;
    public const int FEELING_FOR_HIMSELF = 50016;
    public const int RECEPTION_BOOKING_CLOSED = 50001;
    public const int SERVER_LOGIN_FAILED = 18456;
    public const int SERVER_NOT_FOUND = 53;
    public const int SIT_SEVERAL_TABLE = 50022;
    public const int SIT_TABLE_FOR_NOT_BOOKED_RECEPTION = 50021;
    public const int TOO_MUCH_SEATED = 50020;

    public string Message { get; private set; }
    public int Number { get; private set; }

    public ModelError(Exception ex) {
      bool found = false;
      if(ex is EntityException) {
        EntityException thisEx = (EntityException)ex;
        if(ex.InnerException is SqlException) {
          SqlException innerEx = (SqlException)thisEx.InnerException;
          switch(innerEx.Number) {
            case ALREADY_CHOSEN_DISH_TYPE:
              Number = innerEx.Number;
              Message = "Vous avez déjà choisi ce type de plat pour cette réception.";
              found = true;
              break;
            case BOOKING_FOR_FULL_RECEPTION:
              Number = innerEx.Number;
              Message = "Il n'y a plus de place pour cette réception";
              found = true;
              break;
            case BOOKING_FOR_INVALID_RECEPTION:
              Number = innerEx.Number;
              Message = "La réception pour laqulle vous voulez vous inscrire n'a pas encore été validée.";
              found = true;
              break;
            case BOOKING_FOR_SIMULTANEOUS_RECEPTION:
              Number = innerEx.Number;
              Message = "Vous êtes déjà inscrit à une réception se passant à cette date-là.";
              found = true;
              break;
            case CHOOSING_DISH_FOR_NOT_BOOKED_RECEPTION:
              Number = innerEx.Number;
              Message = "Vous ne pouvez pas choisir un plat pour une réception à laquelle vous n'êtes pas inscrit.";
              found = true;
              break;
            case CHOSEN_DISH_NOT_IN_MENU:
              Number = innerEx.Number;
              Message = "Le plat choisi ne figure pas dans le menu.";
              found = true;
              break;
            case CLOSING_BOOKING_DATE_AFTER_RECEPTION_DATE:
              Number = innerEx.Number;
              Message = "Vous ne pouvez pas choisir une date de clôture postérieure à la date de la réception.";
              found = true;
              break;
            case DATABASE_NOT_FOUND:
              Number = innerEx.Number;
              Message = "Impossible d'accéder à la base de données. Veuillez contacter votre support informatique.";
              found = true;
              break;
            case DATA_NOT_UP_TO_DATE:
              Number = innerEx.Number;
              Message = "Les données de votre formulaire n'étaient pas à jour, veuillez recommencer.";
              found = true;
              break;
            case FEELING_FOR_HIMSELF:
              Number = innerEx.Number;
              Message = "Vous ne pouvez pas définir un ressentiment pour vous-même.";
              found = true;
              break;
            case RECEPTION_BOOKING_CLOSED:
              Number = innerEx.Number;
              Message = "Les inscriptions pour cette réception sont clôturées.";
              found = true;
              break;
            case SERVER_LOGIN_FAILED:
              Number = innerEx.Number;
              Message = "Échec de l'identification sur le serveur. Veuillez contacter votre support informatique.";
              found = true;
              break;
            case SERVER_NOT_FOUND:
              Number = innerEx.Number;
              Message = "Imossible de trouver le serveur de base de données. Veuillez contacter votre support informatique.";
              found = true;
              break;
            case SIT_SEVERAL_TABLE:
              Number = innerEx.Number;
              Message = "L'invité est déjà assis à une autre table.";
              found = true;
              break;
            case SIT_TABLE_FOR_NOT_BOOKED_RECEPTION:
              Number = innerEx.Number;
              Message = "L'invité n'est pas inscrit à la réception pour laquelle vous essayez de l'asseoir à une table.";
              found = true;
              break;
            case TOO_MUCH_SEATED:
              Number = innerEx.Number;
              Message = "Il y a trop d'invités assis à cette table.";
              found = true;
              break;
          }
        }
      }
      if(!found) {
        Message += "Erreur non supportée. Veuillez communiqer les informations suivantes à votre support informatique:\n" +
                   "Type : " + ex.GetType().ToString() + "\n" +
                   "Message : " + ex.Message + "\n" +
                   "Inner Type : " + ex.InnerException.GetType().ToString() + "\n" +
                   "Inner message : " + ex.InnerException.Message;
        Number = -1;
        //throw ex;
      }
    }
  }
}
