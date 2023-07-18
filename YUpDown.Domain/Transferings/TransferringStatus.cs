namespace YUpDown.Registration.Domain.Transferings
{
    public enum TransferringStatus
    {
        /// <summary>
        /// Готов к трансферингу
        /// </summary>
        Ready,

        /// <summary>
        /// Идет передача данных
        /// </summary>
        Transfering,

        /// <summary>
        /// Передача временно приостановлена
        /// </summary>
        Pause,

        /// <summary>
        /// Передача отменена
        /// </summary>
        Cancelled,

        /// <summary>
        /// Связь с конечной точкой оборвана. Идет повторное соединение
        /// </summary>
        Reconnection,

        /// <summary>
        /// Передача успешно завершена
        /// </summary>
        Completed,

        /// <summary>
        /// Не удалось переподключиться после обрыва соединения
        /// </summary>
        Error
    }
}
